using System;

namespace DB
{
    public class Key
    {
        public string DocType  { get; set; }
        public Guid ID { get; set; }
        public Key(string type, Guid id)
        {
            this.DocType = type;
            this.ID  = id;
        }

        public Key(string type, string id)
        {
            this.DocType = type;
            this.ID  = new Guid(id);
        }

        public override string ToString()
        {
            return DocType + "::" + ID.ToString();
        }
    }

    
}