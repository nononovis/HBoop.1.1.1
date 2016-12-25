using HBoop.Model.Bson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Api
{
    public static class InitData
    {
        public static IEnumerable<Product> ProductSampleDatas()
        {

            return new List<Product>()
            {
                new Product() {
                                     Description ="Brushing",
                                     Name="Brushing",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Brushing",
                                       Name="PRC_BRUSHING" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =45
                                      },
                                       LogoPicture = new Media()
                                       {
                                            Description="Logo image brushing",
                                             Name ="LG_IMG_BRUSHING",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_brushing.png"
                                       },
                                       Genre = new TypeEntity()
                                        {
                                                Code="20",
                                                Description ="Homme ou femme",
                                                Name="Mix"
                                        }
                                },

                                new Product()
                                {
                                     Description ="Coloration",
                                     Name="Coloration",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Coloration",
                                       Name="PRC_COLORATION" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =45
                                      },
                                       LogoPicture = new Media()
                                       {
                                               Description="Logo image coloration",
                                               Name ="LG_IMG_COLORATION",
                                               Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_coloration.png"
                                       },
                                        Genre = new TypeEntity()
                                        {
                                                Code="20",
                                                Description ="Homme ou femme",
                                                Name="Mix"
                                        }
                                },
                                     new Product() {
                                     Description ="Brushing",
                                     Name="Brushing",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Brushing",
                                       Name="PRC_BRUSHING" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =45
                                      },
                                       LogoPicture = new Media()
                                       {
                                            Description="Logo image brushing",
                                             Name ="LG_IMG_BRUSHING",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_brushing.png"
                                       },
                                       Genre = new TypeEntity()
                                        {
                                                Code="20",
                                                Description ="Homme ou femme",
                                                Name="Mix"
                                        }

                                },
                                     new Product() {
                                     Description ="Balayage Alianza",
                                     Name="Balayage Alianza",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Balayage Alianza",
                                       Name="PRC_BALAYAGEALIANZA" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =45
                                      },
                                       LogoPicture = new Media()
                                       {
                                            Description="Logo image balayage alianza",
                                            Name ="LG_IMG_BALAYAGEALIANZA",
                                            Status =1,
                                            MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_balayagealianza.png"
                                       },
                                       Genre = new TypeEntity()
                                        {
                                                Code="21",
                                                Description ="femme",
                                                Name="Femme"
                                        }

                                },
                                     new Product() {
                                     Description ="Coupe ee Brushing",
                                     Name="Coupe et Brushing",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Coupe et Brushing",
                                       Name="PRC_COUPEBRUSHING" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =90
                                      },
                                       LogoPicture = new Media()
                                       {
                                            Description="Logo image coupe brushing",
                                             Name ="LG_IMG_COUPEBRUSHING",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_coupebrushing.png"
                                       },
                                       Genre = new TypeEntity()
                                        {
                                                Code="20",
                                                Description ="Homme ou femme",
                                                Name="Mix"
                                        }
                                },
                                  new Product() {
                                     Description ="Shampoing et Lissage",
                                     Name="Shampoing et Lissage",
                                     Discount= new Discount()
                                     {
                                        Name= "SOLDES HIVERS",
                                        Description="SOLDES APRES NOEL",
                                        Status= 1,
                                        Rate= 25,
                                        DateFrom= DateTime.UtcNow.AddMonths(1),
                                        DateTo= DateTime.UtcNow.AddDays(45)
                                     },
                                     Status =1,
                                     Price = new Price()
                                     {
                                       Description= "Shampoing et Lissage",
                                       Name="PRC_COUPEBRUSHING" ,
                                       UnitPrice=32.5M
                                     },
                                      Time=new Time()
                                      {
                                            Minute =30
                                      },
                                       LogoPicture = new Media()
                                       {
                                            Description="Logo image Shampoing et Lissage",
                                             Name ="LG_IMG_SHAMPOINGLISSAGE",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_shampoinglissage.png"
                                       },
                                       Genre = new TypeEntity()
                                        {
                                                Code="20",
                                                Description ="Homme ou femme",
                                                Name="Mix"
                                        }
                                }

            };
        }

        public static IEnumerable<ProductCategory> ProductCategorySample()
        {
            return new List<ProductCategory>()
            {
                new ProductCategory()
                {
                    Description ="Beauté",
                    Name ="Beauté",
                              LogoPicture = new Media()
                                       {
                                            Description="Logo beauté",
                                             Name ="LG_IMG_BEAUTE",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_beaute.png"
                                       },
                              Status = 1,
                              Products = ProductSampleDatas().ToList()
                },
                new ProductCategory()
                {
                     Description ="Coiffure",
                     Name ="Coiffure",
                              LogoPicture = new Media()
                                       {
                                            Description="Logo coiffure",
                                             Name ="LG_IMG_COIFFURE",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_coiffure.png"
                                       },
                               Status = 1,
                              Products = ProductSampleDatas().ToList()
                },
                 new ProductCategory()
                {
                    Description ="Forme et Minceur",
                    Name ="Forme et Minceur",
                    LogoPicture = new Media()
                                       {
                                            Description="Logo forme minceur",
                                             Name ="LG_IMG_FORMEMINCEUR",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_coiffure.png"
                                       },
                   Status = 1
                },
                 new ProductCategory()
                {
                    Description ="Massage et Spa",
                    Name ="Massage et Spa",
                    LogoPicture = new Media()
                                       {
                                            Description="Logo massage et spa",
                                             Name ="LG_IMG_MASSAGEETSPA",
                                              Status =1,
                                               MediaType = new TypeEntity()
                                               {
                                                     Code="10",
                                                     Description ="Picture",
                                                     Name="IMG"
                                               },
                                                Path =@"C:\Medias\Pictures\lg_massagespa.png"
                                       },
                   Status = 1
                }
            };
        }

        public static IEnumerable<Affiliate> AffiliateSample()
        {
            return new List<Affiliate>()
            {
                 new  Affiliate()
                 {
                      Name ="Salon Saint-Honoré",
                       AffiliateType = new TypeEntity()
                       {
                            Name="FIX",
                            Code="0030",
                            Description ="Site fixe"                            
                       },
                        Description ="Salon Test",
                        Status=1,
                        Store= new Store()
                        {
                        Description="Store Saint-Honoré",
                        Name="Store Saint-Honoré",
                        Latitude =48.8728833,
                        Longitude=-2.310611111111,

                        Address = new Address ()
                        {
                            Name="Principale",
                                AddressLine1="3,rue du Faubourg Saint-Honoré",
                                City ="Paris",
                                Country ="France",
                                ZipCode="75008"
                        }  
                        }
                 },
                 new  Affiliate()
                 {
                      Name ="Salon Rivoli",
                       AffiliateType = new TypeEntity()
                       {
                            Name="FIX",
                            Code="0030",
                            Description ="Site fixe 2"
                       },
                         Description ="Salon Rivoli",
                         Status=1,
                          Store= new Store()
                          {
                            Description="store Rivoli ",
                            Name="Store  Rivoli",
                            Latitude =48.8604502,
                            Longitude=-2.34222120000004,

                            Address = new Address ()
                            {
                                Name="Principale",
                                    AddressLine1="3,rue de rivoli",
                                    City ="Paris",
                                    Country ="France",
                                    ZipCode="75001"
                            }
                          }
                 }


            };
        }
        
        public static IEnumerable<Store> StoreSample()
        {
            return new List<Store>()
            {
                new Store()
                {
                    Description = "Store Saint-Honoré",
                    Name = "Store Saint-Honoré",
                    Latitude = 48.8728833,
                    Longitude = -2.310611111111,

                    Address = new Address()
                    {
                        Name = "Principale",
                        AddressLine1 = "3,rue du Faubourg Saint-Honoré",
                        City = "Paris",
                        Country = "France",
                        ZipCode = "75008"
                    }
                },
               new Store()
               {
                   Description = "store Rivoli ",
                   Name = "Store  Rivoli",
                   Latitude = 48.8604502,
                   Longitude = -2.34222120000004,

                   Address = new Address()
                   {
                       Name = "Principale",
                       AddressLine1 = "3,rue de rivoli",
                       City = "Paris",
                       Country = "France",
                       ZipCode = "75001"
                   }
               }
             };
        }
    }
}
