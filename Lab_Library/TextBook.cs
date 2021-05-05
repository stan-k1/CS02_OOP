using System;

namespace Lab_Library
{
    public class TextBook : Publication
    {
        public string Editor { get; set; }

        public TextBook(string title, string author, string publisher, string editor)
            : base( title,  author,  publisher)
        {
            Editor = editor;
        }

        public override void Rent(Member member)
        {
            Available = false;
            LastUpdate=DateTime.Now;
            member.RentedObjects.Add(this);
            Console.WriteLine($"{member.FirstName} {member.LastName} has rented {Title} by {Author} edited by {Editor}.");
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
            Console.WriteLine($"{member.FirstName} {member.LastName} has returned {Title} by {Author} edited by {Editor}.");
        }
    }
}