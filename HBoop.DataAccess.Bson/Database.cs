using HBoop.Model.Bson.Entities;
using MongoDB.Driver;
using System;
using System.Configuration;

namespace HBoop.DataAccess.Bson
{
    internal class Database<T> where T : IEntity

    {

        private Database()

        {

        }


        internal static IMongoCollection<T> GetCollection()
        {
            return GetCollectionFromConnectionString(GetConnectionString());
        }

        internal static IMongoCollection<T> GetCollectionFromConnectionString(string connectionString)
        {
            return GetCollectionFromConnectionString(connectionString, GetCollectionName());
        }


        #region Collection Name


        private static IMongoCollection<T> GetCollectionFromConnectionString(string connectionString, string collectionName)

        {

            return GetCollectionFromUrl(new MongoUrl(connectionString), collectionName);

        }

        private static IMongoCollection<T> GetCollectionFromUrl(MongoUrl url)

        {

            return GetCollectionFromUrl(url, GetCollectionName());

        }

        internal static IMongoCollection<T> GetCollectionFromUrl(MongoUrl url, string collectionName)

        {

            return GetDatabaseFromUrl(url).GetCollection<T>(collectionName);

        }

        private static IMongoDatabase GetDatabaseFromUrl(MongoUrl url)

        {

            var client = new MongoClient(url);

            return client.GetDatabase(url.DatabaseName); // WriteConcern defaulted to Acknowledged

        }

        private static string GetCollectionName()

        {

            return  typeof(T).Name;

        }
        #endregion Collection Name


        #region Connection String


        static string GetDatabaseName()
        {
            return ConfigurationManager.AppSettings.Get("MongoDbDatabaseName");
        }

        static string GetConnectionString()
        {
            var con = (ConfigurationManager.AppSettings.Get("MongoDbConnectionString"));

            return (ConfigurationManager.AppSettings.Get("MongoDbConnectionString")).Replace("DB_NAME", GetDatabaseName());
        }

        #endregion Connection String

    }

}