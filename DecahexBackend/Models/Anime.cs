using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Anime
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int AnimeId { get; set; }
        public string Title { get; set; } = null!;
        public string Season { get; set; } = null!;
        public string Year { get; set; } = null!;
        public int Episodes { get; set; }
        public string Rating { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Agrees { get; set; }
        public int Disagrees { get; set; }
    }
}
