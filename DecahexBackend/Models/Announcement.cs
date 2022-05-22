using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Announcement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int AnnouncementId { get; set; }
        public string Date { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
