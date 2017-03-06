using System;
using Couchbase;
using Couchbase.Core;
using Configuration;
using Couchbase.Management;

namespace DB
{
    public static class Bucket
    {
        public static IBucket getBucket(string BucketAddress)
        {
            return ClusterHelper.GetBucket(CouchbaseConfig.getConfig()[BucketAddress]);
        }

        public static IBucketManager getBucketManager(IBucket _bucket)
        {
            return _bucket.CreateManager(CouchbaseConfig.getConfig()["Couchbase:username"], CouchbaseConfig.getConfig()["Couchbase:password"]);
        }
    }
}