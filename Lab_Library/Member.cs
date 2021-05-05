using System;
using System.Collections.Generic;

namespace Lab_Library
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }  = true;
        public List<IRentable> RentedObjects { get; set; } = new();

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ToggleActive()
        {
            Active = !Active;

            if (Active) Console.WriteLine($"Member {FirstName} {LastName} is now marked as active.");
            else Console.WriteLine($"Member {FirstName} {LastName} is now marked as inactive.");
        }

        public void GetRentedPubs()
        {
            foreach (IRentable rentedObject in RentedObjects)
            {
                if (rentedObject is Publication)
                {
                    Publication rentedPublication = (Publication)rentedObject;
                    Console.WriteLine(rentedPublication.Title);
                }
            }
        }
    }
}