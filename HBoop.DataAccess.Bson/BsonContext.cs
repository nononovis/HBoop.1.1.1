using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.DataAccess.Bson
{
    public class BsonContext
    {

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static BsonContext()
        {
            _client = new MongoClient(GetConnectionString());
            _database = _client.GetDatabase(GetDatabaseName());
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            return _database.GetCollection<T>(typeof(T).Name.ToLower());
        }


        #region Connection String

        static string GetDatabaseName()
        {
            return ConfigurationManager.AppSettings.Get("MongoDbDatabaseName");
        }

        static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings.Get("MongoDbConnectionString").Replace("DB_NAME", GetDatabaseName());
        }

        #endregion Connection String
    }
}
