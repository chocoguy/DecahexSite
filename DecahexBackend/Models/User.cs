using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("UserName")]
        public string UserName { get; set; } = null!;

        public string UserLevel { get; set; } = null!;
        public bool IsSuperUser { get; set; } = false;

    }
}
