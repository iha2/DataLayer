using System;

namespace DB
{
    public class SingleDocument <T>
    {
        public Key ID { get; set; }
        public T Doc { get; set; }
    }
}