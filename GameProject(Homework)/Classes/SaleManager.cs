using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Interfaces;

namespace GameProject_Homework_.Classes
{
    class SaleManager : ISaleService
    {
        public void MakeSale(Campaign campaign, double gamePrice)
        {
            double _gamePrice;
            string saleString = $"Yeni bir satış yapıldı. Fiyatı: ";
            if (campaign.Off > 0)
            {
                _gamePrice = gamePrice - GetXPercentOfY(gamePrice, campaign.Off);
                saleString += $"{_gamePrice}TL. (Asıl fiyat: {gamePrice}TL.)";
            }
            else
            {
                saleString += $"{gamePrice}TL.";
            }
            Console.WriteLine(saleString);
        }

        public double GetXPercentOfY(double x, double off)
        {
            return x * off / 100;
        }
    }
}
