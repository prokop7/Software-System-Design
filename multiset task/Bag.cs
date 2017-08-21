using System;
using System.Collections.Generic;
using System.Linq;

namespace bagProject
{
    public class Bag<T>
    {
        protected readonly Dictionary<T, uint> Dictionary;

        public Bag() => Dictionary = new Dictionary<T, uint>();

        /// <summary>
        /// Create Bag from already existing dictionary
        /// </summary>
        private Bag(Dictionary<T, uint> dict) => Dictionary = new Dictionary<T, uint>(dict);

        /// <summary>
        /// Add element <param name="v"/> with quantity <param name="n"/>
        /// </summary>
        public virtual void Add(T v, uint n)
        {
            if (Dictionary.ContainsKey(v))
                Dictionary[v] += n;
            else
                Dictionary.Add(v, n);
        }

        /// <summary>
        /// Remove elemnt <param name="v"/> with quantity <param name="n"/> from this Bag.
        /// Works with soft handling exceptions. If element doesn't present then nothing will be removed.
        /// </summary>
        public void Remove(T v, uint n)
        {
            if (Dictionary.ContainsKey(v))
                if (Dictionary[v] - n <= 0)
                    Dictionary.Remove(v);
                else
                    Dictionary[v] -= n;
        }

        /// <summary>
        /// Subtract elemets from this dictionary.
        /// </summary>
        /// <param name="other">Dict which will be substracted</param>
        /// <returns>New Bag as result of operation</returns>
        public Bag<T> Substract(Bag<T> other)
        {
            var newBag = new Bag<T>(Dictionary);
            foreach (var keyValuePair in Dictionary)
                if (other.Dictionary.ContainsKey(keyValuePair.Key))
                    newBag.Remove(keyValuePair.Key, other.Dictionary[keyValuePair.Key]);
            return newBag;
        }
    
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var dict1 = Dictionary;
            var dict2 = ((Bag<T>) obj).Dictionary;
            return dict1.Count == dict2.Count && IsSubdictionary(dict1, dict2);
        }

        public static bool operator ==(Bag<T> left, Bag<T> right) => left != null && left.Equals(right);

        public static bool operator !=(Bag<T> left, Bag<T> right) => !(left == right);

        /// <summary>
        /// Return wherther dict1 is a subset of dict2
        /// </summary>
        /// <param name="dict1"></param>
        /// <param name="dict2"></param>
        /// <returns>True if dict1 ∈ dict2</returns>
        private static bool IsSubdictionary(Dictionary<T, uint> dict1, Dictionary<T, uint> dict2) 
            => dict1.All(keyValuePair => 
                dict2.ContainsKey(keyValuePair.Key) && dict2[keyValuePair.Key] == keyValuePair.Value);

        public override int GetHashCode() => Dictionary.GetHashCode();

        public static Bag<T> operator -(Bag<T> left, Bag<T> right) => left.Substract(right);

        // Override default ToString() method.
        public override string ToString() => Dictionary.Aggregate(string.Empty, (current, keyValuePair) =>
            current + $"Obj={keyValuePair.Key.ToString()} num={keyValuePair.Value}\t");
    }
}