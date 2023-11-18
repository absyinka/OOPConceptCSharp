using System;

namespace TestSolid
{
    public class BookWriter : Writer
    {
        public BookWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I am a vlogger on tiktok!");
        }

        public override void Write()
        {
            Console.WriteLine("I am an author of 57 books");
        }
    }
}
