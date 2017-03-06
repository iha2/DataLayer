using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Couchbase.Core;
using Couchbase;
using Configuration;
using DB;


namespace Models
{
    public class Feed
    {
        [JsonProperty("FeedID")]
        public virtual Guid ID { get; set; }

        [JsonProperty("FeedUserID")]
        public virtual Guid FeedUserID { get; set; }

        [JsonProperty("Name")]
        public virtual string Name { get; set; }

        [JsonProperty("LastUpdatedDate")]
        public virtual DateTime LastUpdatedDate { get; set; }

        [JsonProperty("Url")]
        public virtual string Url { get; set; }

        [JsonProperty("User")]
        public virtual string User { get; set; }

        [JsonProperty("Password")]
        public virtual string Password { get; set; }
    }
}