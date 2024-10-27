using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApplication8.Pages.Models;

namespace WebApplication8.Pages.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Books> _booksCollection;
        public BookService(
            IOptions<BookDatabaseSettings> bookDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookDatabaseSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<Books>(
                bookDatabaseSettings.Value.BooksCollectionName);
        }
        public bool InsertBook(Books newBook)
        {
            try
            {
                _booksCollection.InsertOne(newBook);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public Books GetBookId(int id) 
        {
            return _booksCollection.Find(x => x.Id == id).FirstOrDefault();
        }
        public Books GetBook()
        {
            return _booksCollection.Find(book => true).FirstOrDefault();
        }
        public List<Books> GetBooks() 
        {
            return _booksCollection.Find(_ => true).ToList();
        }
    }
}
