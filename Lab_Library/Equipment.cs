using System;

namespace Lab_Library
{
    public class Equipment : IRentable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Available { get; set; }

        public Equipment(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Rent(Member member)
        {
            Available = false;
            LastUpdate = DateTime.Now;
            member.RentedObjects.Add(this);
            Console.WriteLine($"{member.FirstName} {member.LastName} has rented {Name}.");
        }

        public void Return(Member member)
        {
            if (member.RentedObjects.IndexOf(this) == -1)
            {
                Console.WriteLine("Could not return. The specified member has not rented the object!");
                return;
            }

            Available = true;
            LastUpdate = DateTime.Now;
            member.RentedObjects.Remove(this);
            Console.WriteLine($"{member.FirstName} {member.LastName} has returned {Name}.");
        }
    }
}