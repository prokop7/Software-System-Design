using System;

class Program
{
    static void Main(string[] args)
    {
        Bag<string> bag1 = new Bag<string>();
        Bag<string> bag2 = new Bag<string>();
        Bag<string> bag3 = new Bag<string>();
        bag1.Add("1", 3);
        bag1.Add("2", 2);
        bag1.Add("3", 2);
        bag2.Add("1", 2);
        bag2.Add("2", 1);  
        bag3.Add("1", 2);
        bag3.Add("2", 1);      
        Console.WriteLine(bag1);
        bag1 -= bag2;
        bag1.Remove("3", 1);
        Console.WriteLine(bag1);
        Console.WriteLine(bag2.Equals(bag3));
    }
}
