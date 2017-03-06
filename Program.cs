using System;
using Models;
using DB;

namespace DataLayer
{
    public static class Startup
    {
        public static void start()
        {
            Configuration.CouchbaseConfig.Initialize();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = Configuration.CouchbaseConfig.getConfig();
            Console.WriteLine(config["Couchbase:server"]);
            Startup.start();
            
            using (var bucket = ClContext.OpenBucket())
            {
                for (var i = 0; i < 123; i++)
                {
                    var Feed = new Feed { 
                        ID = Guid.NewGuid(), 
                        FeedUserID = Guid.NewGuid(),
                        Name = "New Homes Feed",
                        LastUpdatedDate = DateTime.Today,
                        Url = "https://www.text.com",
                        User = "here",
                        Password = "there"
                    };
                    var doc = new DB.SingleDocument<Feed> {
                        ID = new Key("Feed", Feed.ID),
                        Doc = Feed
                    };

                    Feeds.add(doc);
                    Console.WriteLine(Feeds.byKey(new Key("Feed", Feed.ID)).ID);
                }
                
            }
            
        }
    }
}
