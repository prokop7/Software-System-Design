using System;

namespace LibrarySystem.Materials
{
    public class AudioVideoMaterials: RentableMaterial
    {
        public AudioVideoMaterials(string name, int quantity, double value, DateTime ageLimit) : 
            base(name, quantity, value, ageLimit)
        {
            CheckOutDuration = new TimeSpan(7 * 3600 * 24 * 2);
        }
    }
}