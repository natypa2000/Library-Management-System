using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication8.Pages.Models
{
    public class Subscribers
    {
        [BsonId]
        public int Id { get; set; } = 0;
        public string firstName { get; set; } = null!;

        public string lastName { get; set; } = null!;
        public List<int> booksId { get; set; }=new List<int>();
    }
}
