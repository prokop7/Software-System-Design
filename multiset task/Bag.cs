using System;
using System.Collections.Generic;

public class Bag<T>
{
    private Dictionary<T, uint> dictionary;

    public Bag() => dictionary = new Dictionary<T, uint>();

    private Bag(Dictionary<T, uint> dict) => dictionary = new Dictionary<T, uint>(dict);

    public void Add(T v, uint n)
    {
        if (dictionary.ContainsKey(v))
            dictionary[v] += n;
        else
            dictionary.Add(v, n);
    }

    public void Remove(T v, uint n)
    {
        if (dictionary.ContainsKey(v))
            if (dictionary[v] - n <= 0)
                dictionary.Remove(v);
            else 
                dictionary[v] -= n;
    }

    public Bag<T> Substract (Bag<T> other) 
    {
        Bag<T> newBag = new Bag<T>(dictionary); 
        foreach(var keyValuePair in dictionary)
            if (other.dictionary.ContainsKey(keyValuePair.Key))
                newBag.Remove(keyValuePair.Key, other.dictionary[keyValuePair.Key]);
        return newBag;
    }

    public override bool Equals(object obj) 
    {
        
        if (obj == null || GetType() != obj.GetType())
            return false;
        var dict1 = this.dictionary;
        var dict2 = ((Bag<T>)obj).dictionary;
        return dict1.Count == dict2.Count && isSubdictionary(dict1, dict2);
    }
    
    private bool isSubdictionary(Dictionary<T, uint> dict1, Dictionary<T, uint> dict2)
    {
        foreach(var keyValuePair in dict1)
            if (!dict2.ContainsKey(keyValuePair.Key) || dict2[keyValuePair.Key] != keyValuePair.Value)
                return false;
        return true;
    }

    public override int GetHashCode() => dictionary.GetHashCode();

    public static Bag<T> operator -(Bag<T> left, Bag<T> right) => left.Substract(right);

    public override string ToString()
    {
        string s = string.Empty;
        foreach(var keyValuePair in dictionary)
            s += $"Obj={keyValuePair.Key.ToString()} num={keyValuePair.Value}\t";
        return s;
    }
    
}