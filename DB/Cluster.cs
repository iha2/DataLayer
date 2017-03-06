
using Couchbase;
using Configuration;
using Couchbase.Core;

namespace DB
{
    public static class ClContext
    {
        public static IBucket OpenBucket()
        {
            return new Cluster().OpenBucket(CouchbaseConfig.getConfig()["Couchbase:buckets:FeedStats"]);
        }

    }
}