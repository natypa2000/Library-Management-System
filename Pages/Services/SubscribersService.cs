using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Net;
using WebApplication8.Pages.Models;

namespace WebApplication8.Pages.Services
{
    public class SubscribersService
    {
        private readonly IMongoCollection<Subscribers> _subscribersCollection;
        public SubscribersService(
            IOptions<SubscribersDatabaseSettings> subscribersDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                subscribersDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
               subscribersDatabaseSettings.Value.DatabaseName);

            _subscribersCollection = mongoDatabase.GetCollection<Subscribers>(
                subscribersDatabaseSettings.Value.BooksCollectionName);
        }
        public bool InsertSub(Subscribers sub)
        {
            try 
            {
                _subscribersCollection.InsertOne(sub);
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
        }
       
        public Subscribers GetId(int id)
        {
            return _subscribersCollection.Find(subscriber => subscriber.Id == id).FirstOrDefault();
          
        }
        public bool UpdateSub(int id, Subscribers newsubscriber)
        {

             _subscribersCollection.ReplaceOne(subscriber => subscriber.Id == id, newsubscriber);
            return true;
            
        }
        public List<Subscribers> GetSubs()
        {
            return _subscribersCollection.Find(_=>true).ToList();
        }
    }
}

