using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Classes;

namespace GameProject_Homework_
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            SaleManager saleManager = new SaleManager();
            Gamer gamer1 = new Gamer() {
                Id = 1,
                FullName = "Ataberk Kasap",
                TcNo = "12345678900",
                NickName = "xAtaberKX",
                BirthDay = new DateTime(2003, 01, 20)
            };
            gamerManager.Add(gamer1);

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Yarı Yarıya!",
                Off = 50
            };

            saleManager.MakeSale(campaign1, 100);

            Console.ReadLine();
        }
    }
}
