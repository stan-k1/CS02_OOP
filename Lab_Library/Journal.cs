using System;
using Microsoft.VisualBasic;

namespace Lab_Library
{
    public class Journal : Publication
    {
        public int IssueNo { get; set; }
        public DateTime PublicationDate { get; set; }

        public Journal(string title, string author, string publisher, int issueNo, DateTime publicationDate)
            : base(title, author, publisher)
        {
            IssueNo = issueNo;
            PublicationDate = publicationDate;
        }

        public override void Rent(Member member)
        {
            Available = false;
            LastUpdate = DateTime.Now;
            member.RentedObjects.Add(this);
            Console.WriteLine($"{member.FirstName} {member.LastName} has rented {Title} no. {IssueNo} by {Author}.");
        }

        public override void Return(Member member)
        {
            if (member.RentedObjects.IndexOf(this) == -1)
            {
                Console.WriteLine("Could not return. The specified member has not rented the object!");
                return;
            }

            Available = true;
            LastUpdate = DateTime.Now;
            member.RentedObjects.Remove(this);
            Console.WriteLine($"{member.FirstName} {member.LastName} has returned {Title} no. {IssueNo} by {Author}.");
        }
    }
}