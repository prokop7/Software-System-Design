using System;
using LibrarySystem.Materials;

namespace LibrarySystem.Cards
{
    public class ProfessorLibraryCard: LibraryCard
    {
        public ProfessorLibraryCard(int cardId, Person ownerPerson) : base(cardId, ownerPerson)
        {
        }

        public override bool CheckOut(RentableMaterial material)
        {
            throw new NotImplementedException();
        }
    }
}