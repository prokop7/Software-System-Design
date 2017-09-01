using System;

namespace LibrarySystem.Materials
{
    public class RentableMaterial
    {
        public string Name { get; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public int OverdueFine { get; set; } = 100;
        public TimeSpan CheckOutDuration { get; set; }
        public DateTime AgeLimit { get; set; }

        public RentableMaterial(string name, int quantity, double value, DateTime ageLimit)
        {
            Name = name;
            Quantity = quantity;
            Value = value;
            AgeLimit = ageLimit;
        }
    }
}