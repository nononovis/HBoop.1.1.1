using Autofac;
using HBoop.DataAccess.Bson;
using HBoop.Model.Bson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.Business.Layer.Autofac
{
   public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Manager<Beneficiary>>().As<IManager<Beneficiary>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Affiliate>>().As<IManager<Affiliate>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Address>>().As<IManager<Address>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Booking>>().As<IManager<Booking>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<BookingDetail>>().As<IManager<BookingDetail>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Comment>>().As<IManager<Comment>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<CreditCard>>().As<IManager<CreditCard>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Currency>>().As<IManager<Currency>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Discount>>().As<IManager<Discount>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Language>>().As<IManager<Language>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Media>>().As<IManager<Media>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Message>>().As<IManager<Message>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Order>>().As<IManager<Order>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<OrderDetail>>().As<IManager<OrderDetail>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Person>>().As<IManager<Person>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Price>>().As<IManager<Price>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Product>>().As<IManager<Product>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<ProductCategory>>().As<IManager<ProductCategory>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Role>>().As<IManager<Role>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<ShipMethod>>().As<IManager<ShipMethod>>().InstancePerLifetimeScope();
            builder.RegisterType<Manager<Store>>().As<IManager<Store>>().InstancePerLifetimeScope();
        }
    }
}
