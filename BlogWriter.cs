using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolid
{
    public class BlogWriter : Writer
    {
        public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I am a Vlogger on youtube");

        }

        public override void Write()
        {
            Console.WriteLine("I write my blog using WordPress");
        }
    }
}
