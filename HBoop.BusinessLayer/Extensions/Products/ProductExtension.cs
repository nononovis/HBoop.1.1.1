using HBoop.DataAccess.Bson;
using HBoop.Model.Bson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.Business.Layer.Products
{
    public static class ProductExtension 
    {
        public static IEnumerable<ProductCategory> All(this IManager<Product> manager)
        {
            yield return  new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
        }

        public static IEnumerable<ProductCategory> GetByAffiliateId(this IManager<Product> manager,string id)
        {
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
        }

        public static IEnumerable<ProductCategory> GetByBeneficiaryId(this IManager<Product> manager ,string id)
        {
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
            yield return new ProductCategory();
        }
    }
}
