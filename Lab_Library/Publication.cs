using System;
using System.Collections.Generic;

namespace Lab_Library
{
    public abstract class Publication : IRentable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Available { get; set; }
        public static List<Publication> Publications = new();

        public abstract void Rent(Member member);
        public abstract void Return(Member member);

        protected Publication(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public static List<Publication> GetAvailables()
        {
            List<Publication> availablePublications = new();
            foreach (Publication pub in Publications)
            {
               if (pub.Available) availablePublications.Add(pub); 
            }

            return availablePublications;
        }

        public int DaysSinceLastUpdate()
        {
            TimeSpan span = DateTime.Now - LastUpdate;
            return span.Days;
        }

    }
}