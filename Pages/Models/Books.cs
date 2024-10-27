using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication8.Pages.Models
{
    public class Books
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;
    

    }
}
