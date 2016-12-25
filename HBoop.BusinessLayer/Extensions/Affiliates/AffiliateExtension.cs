using HBoop.DataAccess.Bson;
using HBoop.Model.Bson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.Business.Layer.Affiliates
{
    public static class AffiliateExtension
    {

        public static IEnumerable<Affiliate> Search(this IManager<Affiliate> manager , string id)
        {
            var affiliates = manager.Find(a=>a.Id ==id);

            return affiliates;
        }
    }
}
