using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace HBoop.Model.Bson.Entities
{

    [BsonIgnoreExtraElements(Inherited = true)]
    public class Entity : IEntity
    {
        public Entity()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }

        public DateTime CreatedDate
        {
            get

            {

                return ObjectId.CreationTime;

            }

        }

        [BsonElement(Order = 0)]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }


        [BsonElement( Order = 1)]
        [BsonRepresentation(BsonType.DateTime)]

        public DateTime ModifiedDate { get; set; }

        private ObjectId ObjectId

        {

            get

            {

                //Incase, this is required if db record is null

                if (Id == null)

                    Id = ObjectId.GenerateNewId().ToString();

                return ObjectId.Parse(Id);

            }

        }

    }

}