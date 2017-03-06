using System;

namespace Models
{
    public class Error
    {
        public string ID { get; set; }
        public Guid FeedID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Log { get; set; }
    }
}