using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    /// <summary>

    /// mongo entity interface

    /// </summary>

    public interface IEntity

    {
        /// <summary>

        /// create date

        /// </summary>

        [BsonIgnore]

        DateTime CreatedDate { get; }



        /// <summary>

        /// id in string format

        /// </summary>

        [BsonId]

        string Id { get; set; }



        /// <summary>

        /// modify date

        /// </summary>

        DateTime ModifiedDate { get; }

    }

}