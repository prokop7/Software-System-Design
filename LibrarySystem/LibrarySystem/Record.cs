using System;

namespace LibrarySystem
{
    public class Record
    {
        public DateTime DateTaken { get; }
        public DateTime DateDue { get; set; } 
        public RentableMaterial Material { get; }
        public bool IsReturned { get; set; } = false

        public Record(DateTime dateTaken, DateTime dateDue, RentableMaterial material)
        {
            DateTaken = dateTaken;
            DateDue = dateDue;
            Material = material;
        }
    }
}