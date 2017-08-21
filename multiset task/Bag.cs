using System.Collections.Generic;
using System.Linq;

public class Bag<T>
{
    private readonly Dictionary<T, uint> _dictionary;

    public Bag() => _dictionary = new Dictionary<T, uint>();

    /// <summary>
    /// Create Bag from already existing dictionary
    /// </summary>
    private Bag(Dictionary<T, uint> dict) => _dictionary = new Dictionary<T, uint>(dict);

    /// <summary>
    /// Add element <param name="v"/> with quantity <param name="n"/>
    /// </summary>
    public void Add(T v, uint n)
    {
        if (_dictionary.ContainsKey(v))
            _dictionary[v] += n;
        else
            _dictionary.Add(v, n);
    }

    /// <summary>
    /// Remove elemnt <param name="v"/> with quantity <param name="n"/> from this Bag.
    /// Works with soft handling exceptions. If element doesn't present then nothing will be removed.
    /// </summary>
    public void Remove(T v, uint n)
    {
        if (_dictionary.ContainsKey(v))
            if (_dictionary[v] - n <= 0)
                _dictionary.Remove(v);
            else
                _dictionary[v] -= n;
    }

    /// <summary>
    /// Subtract elemets from this dictionary.
    /// </summary>
    /// <param name="other">Dict which will be substracted</param>
    /// <returns>New Bag as result of operation</returns>
    public Bag<T> Substract(Bag<T> other)
    {
        var newBag = new Bag<T>(_dictionary);
        foreach (var keyValuePair in _dictionary)
            if (other._dictionary.ContainsKey(keyValuePair.Key))
                newBag.Remove(keyValuePair.Key, other._dictionary[keyValuePair.Key]);
        return newBag;
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        var dict1 = _dictionary;
        var dict2 = ((Bag<T>) obj)._dictionary;
        return dict1.Count == dict2.Count && IsSubdictionary(dict1, dict2);
    }

    /// <summary>
    /// Return wherther dict1 is a subset of dict2
    /// </summary>
    /// <param name="dict1"></param>
    /// <param name="dict2"></param>
    /// <returns>True if dict1 ∈ dict2</returns>
    private static bool IsSubdictionary(Dictionary<T, uint> dict1, Dictionary<T, uint> dict2) 
        => dict1.All(keyValuePair => 
            dict2.ContainsKey(keyValuePair.Key) && dict2[keyValuePair.Key] == keyValuePair.Value);

    public override int GetHashCode() => _dictionary.GetHashCode();

    public static Bag<T> operator -(Bag<T> left, Bag<T> right) => left.Substract(right);

    // Override default ToString() method.
    public override string ToString() => _dictionary.Aggregate(string.Empty, (current, keyValuePair) =>
        current + $"Obj={keyValuePair.Key.ToString()} num={keyValuePair.Value}\t");
}