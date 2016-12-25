using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Web.Http;
using HBoop.DataAccess.Bson;
using Autofac;
using HBoop.Api.Controllers;
using HBoop.Business.Layer;
using HBoop.Business.Layer.Autofac;
using Autofac.Extensions.DependencyInjection;

namespace HBoop.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddApplicationInsightsSettings(developerMode: true)
                .AddEnvironmentVariables();

           this.Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; private set; }

        public IContainer ApplicationContainer { get; private set; }
        
        // This method gets called by the runtime. Use this method to add services to the container
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);  
            services.AddMvc();

            var afBuilder = new ContainerBuilder();
            afBuilder.RegisterModule(new BusinessModule());
            afBuilder.RegisterType<BusinessLayer>().As<IBusinessLayer>();
            afBuilder.RegisterGeneric(typeof(Manager<>)).As(typeof(IManager<>));
            afBuilder.Populate(services);           
            ApplicationContainer = afBuilder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,IApplicationLifetime appLifeTime)
        {

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseMvc();

            appLifeTime.ApplicationStopped.Register(() => this.ApplicationContainer.Dispose());


        }
    }
}
