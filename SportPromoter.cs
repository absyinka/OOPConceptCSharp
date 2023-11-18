using System;

namespace TestSolid
{
    public class SportPromoter : Promoter, IVlogger, ITrain
    {
        public SportPromoter(string firstName, string lastName, string phone) : base(firstName, lastName, phone)
        {
        }

        public void Vlog()
        {
            Console.WriteLine("I do my vlogging on SportPro Vids");
        }

        public void WorkOut()
        {
            Console.WriteLine($"I am sport promoter I do workout at the Gym. Here is my business card: {MyBusinessCard}");
        }

        protected override void ShareWithInnerCirlces()
        {
            Console.WriteLine("Share with friends of friends on youtube");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("Do paid ads on facebook business, and Google Adsense");
        }
    }
}
