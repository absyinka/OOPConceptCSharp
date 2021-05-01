using System;
using System.Collections.Generic;
using System.Text;

namespace TestSolid
{
    public class MusicPromoter : Promoter
    {
        public MusicPromoter(string firstName, string lastName, string phone) : base(firstName, lastName, phone)
        {
        }

        protected override void ShareWithInnerCirlces()
        {
            Console.WriteLine("Share with friends of friends on twitter");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("Paid ads on youtube music ads, tiktok and Audio Mack");
        }
    }
}
