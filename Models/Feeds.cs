using System;
using DB;

using Couchbase;

namespace Models
{
    public static class Feeds
    {
        public static Feed byKey(Key key)
        {
            Feed feed = null;
            using (var bucket = ClContext.OpenBucket())
            {
                Console.WriteLine("are");
                feed = bucket.GetDocument<Feed>(key.ToString()).Document.Content;
            }
            return feed;
        }

        public static void add(DB.SingleDocument<Feed> doc)
        {
            using (var bucket = ClContext.OpenBucket())
            {
                bucket.UpsertAsync( new Couchbase.Document<Feed>() {
                    Id = doc.ID.ToString(),
                    Content = doc.Doc
                });
            }
        }
        public static void add(Feed feed)
        {
            using (var bucket = ClContext.OpenBucket())
            {
                bucket.UpsertAsync( new Couchbase.Document<Feed>() {
                    Id = feed.ID.ToString(),
                    Content = feed
                });
            }
        }
    }
}