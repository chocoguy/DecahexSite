using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Snippet
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int SnippetId { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Platform { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Styling { get; set; } = null!;
    }
}
