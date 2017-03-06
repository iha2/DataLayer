using System;
using DB;

namespace Models
{
    public static class Errors
    {
        public static Error byKey(Key key)
        {
            Error err = null;
            using (var bucket = ClContext.OpenBucket())
            {
                err = bucket.GetDocument<Error>(key.ToString()).Document.Content;
            }
            return err;
        }

        public static void add(DB.SingleDocument<Error> doc)
        {
            using (var bucket = ClContext.OpenBucket())
            {
                bucket.UpsertAsync( new Couchbase.Document<Error>() {
                    Id = doc.ID.ToString(),
                    Content = doc.Doc
                });
            }
        }

        public static void add(Error err)
        {
            using (var bucket = ClContext.OpenBucket())
            {
                bucket.UpsertAsync( new Couchbase.Document<Error>() {
                    Id = err.ID.ToString(),
                    Content = err
                });
            }
        }
    }
}