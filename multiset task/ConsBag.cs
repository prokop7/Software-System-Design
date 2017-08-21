using System;

namespace bagProject
{
    public class ConsBag<T>: Bag<T>
    {
        protected readonly uint Limit;
        
        /// <summary>
        /// Set <param name="limit"/> during initialization
        /// </summary>
        public ConsBag(uint limit) => Limit = limit;

        /// <summary>
        /// Bag can't contain more objects <param name="v"/> than <see cref="Limit"/>.
        /// Bag will be filled on until reached limit or with <param name="n"/> elemts.
        /// </summary>
        public override void Add(T v, uint n)
        {
            if (Dictionary.ContainsKey(v) && Dictionary[v] + n > Limit)
                base.Add(v, Math.Min(Limit - Dictionary[v], n));
            else
                base.Add(v, n);
        }
    }
}