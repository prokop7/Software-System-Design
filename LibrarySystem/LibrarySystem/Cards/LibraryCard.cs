using System;
using System.Collections.Generic;
using LibrarySystem.Materials;

namespace LibrarySystem.Cards
{
    public class LibraryCard
    {
        public LibraryCard(int cardId, Person ownerPerson)
        {
            CardId = cardId;
            OwnerPerson = ownerPerson;
            Records = new List<Record>();
        }
        

        public int CardId { get; }
        public Person OwnerPerson { get; }
        public List<Record> Records { get; set; }

        
        public virtual bool CheckOut(RentableMaterial material)
        {
            throw new NotImplementedException();
        }
    }
}