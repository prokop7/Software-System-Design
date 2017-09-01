using System;
using LibrarySystem.Materials;

namespace LibrarySystem.Cards
{
    public class ChildLibraryCard: LibraryCard
    {
        public ChildLibraryCard(int cardId, Person ownerPerson) : base(cardId, ownerPerson)
        {
        }

        /// <summary>
        /// With age verification.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool CheckOut(RentableMaterial material)
        {
            throw new NotImplementedException();
        }
    }
}