using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Hentai
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int HentaiId { get; set; }
        public string Title { get; set; } = null!;
        public string Picture { get; set; } = null!;
    }
}
