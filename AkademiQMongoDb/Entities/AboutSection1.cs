using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AkademiQMongoDb.Entities
{
    public class AboutSection1
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutSection1Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
