using System;

namespace Lab_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            IRentable myJournal = new Journal("Advances in Philosophy", "Bertrand Russell",
                "Worldwide Publications", 101, new DateTime(1950, 1, 31) );
            IRentable myTextbook = new TextBook("Marketing Management", "Phillip Kotler", "Pearson", "Sally Yagan");
            Member myMember = new Member("Darya", "Alexandrova");
            Console.WriteLine(myMember.Active);
            myJournal.Rent(myMember);
            myTextbook.Rent(myMember);
            Console.WriteLine(myJournal.IsAvailable());
            myTextbook.Return(myMember);
            Console.WriteLine(myTextbook.IsAvailable());
            myMember.GetRentedPubs();
            myMember.ToggleActive();
        }
    }
}
