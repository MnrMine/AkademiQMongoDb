using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AkademiQMongoDb.Entities
{
    public class AboutSection2
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutSection2Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
