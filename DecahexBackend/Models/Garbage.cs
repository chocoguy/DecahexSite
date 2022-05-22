using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Garbage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int GarbageId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public string Styling { get; set; } = null!;
    }
}
