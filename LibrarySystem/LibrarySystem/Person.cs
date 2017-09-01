using System;

namespace LibrarySystem
{
    public class Person
    {
        public string Name { get; }
        public string Address { get; }
        public string PhoneNumber { get; }
        public DateTime DateOfBirth { get; }

        public Person(string name, string address, string phoneNumber, DateTime dateOfBirth)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }
    }
}