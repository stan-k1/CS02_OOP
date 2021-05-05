using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Lab_Library
{
    public interface IRentable
    {
        public DateTime LastUpdate { get; set; }
        public bool Available { get; set; }

        public void Rent(Member member);
        public void Return(Member member);

        public bool IsAvailable()
        {
            return Available;
        }


    }
}