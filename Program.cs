using System;
using System.Collections.Generic;

namespace TestSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() { new SportPromoter("Jay", "Alvin", "088199190901"),
                                                                new MusicPromoter("Joe", "Boy", "99919910010")};

            foreach (var promoter in promoters)
            {
                Console.WriteLine(promoter.MyBusinessCard);
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>() { new BlogWriter("Mavin", "Write"), new BookWriter("Authur", "Davids") };

            foreach (var writer in writers)
            {
                writer.Write();
            }

            List<ITrain> trainers = new List<ITrain>() { new SportPromoter("Jay", "Alvin", "088199190901"), new SportPromoter("Coco", "Yams", "9881967191") };

            foreach (var trainer in trainers)
            {
                trainer.WorkOut();
            }

            List<IVlogger> vloggers = new List<IVlogger>() { new SportPromoter("Coco", "Yams", "9881967191"), new BookWriter("Authur", "Davids") };

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
        }
    }
}
