using System;

namespace linko.Domain
{
    public class MasterEntity
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeletdateDate { get; set; }
        public byte[] Version { get; set; }
    }
}
