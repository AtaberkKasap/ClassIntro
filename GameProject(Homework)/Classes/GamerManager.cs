using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Interfaces;

namespace GameProject_Homework_.Classes
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            if (CheckGamerFromEDevlet(gamer))
            {
                Console.WriteLine($"{gamer.NickName} sisteme eklendi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer.NickName} sistemden silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.NickName} isimli kullanıcı güncellendi.");
        }

        public bool CheckGamerFromEDevlet(Gamer gamer)
        {
            if (gamer.TcNo == "12345678900")
            {
                return true;
            }
            return false;
        }
    }
}
