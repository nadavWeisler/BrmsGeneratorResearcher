using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PopUp_Researcher.Models
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}
