using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Misc
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int MiscId { get; set; }
        public string Phrase { get; set; } = null!;
        public string CounterPhrase { get; set; } = null!;
    }
}
