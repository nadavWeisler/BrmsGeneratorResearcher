using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using MongoDB.Driver;
using PopUp_Researcher.Models;

namespace PopUp_Researcher.Helpers
{
    public class DbHelper
    {
        private MongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Trial> experiment_collection;
        private IMongoCollection<User> User_collection;
        public DbHelper(string dbString= "mongodb://user1_regular:user1Pass@ds351827.mlab.com:51827/popup_dev")
        {
            this._client = new MongoClient(dbString);
            this._database = _client.GetDatabase("PopUp_dev");
            this.experiment_collection = _database.GetCollection<Trial>("experiments");
            this.User_collection = _database.GetCollection<User>("User");
        }

        static string Sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        public void InsertExperiment(Trial exp)
        {
            this.experiment_collection.InsertOne(exp);
        }

        public User GetUser(string name, string password)
        {
            var pass = Sha256(password);
            var filter = Builders<User>.Filter.Eq("name", name);
            //filter = filter & (Builders<User>.Filter.Eq("password", password));
            
            var query =
                from e in User_collection.AsQueryable<User>()
                where e.Name == "test"
                select e;
            foreach (var employee in query)
            {
                    
                // process employees named "John"
            }
            var results = this.User_collection.Find(filter).ToList();
            if (results == null || results.Count == 0)
            {
                return null;
            }
            else
            {
                return results[0];
            }
           
        }
    }
}
