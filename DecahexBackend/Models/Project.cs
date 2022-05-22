using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DecahexBackend.Models
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string DownloadLink { get; set; } = null!;
        public string GithubLink { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public string Styling { get; set; } = null!;
    }
}
