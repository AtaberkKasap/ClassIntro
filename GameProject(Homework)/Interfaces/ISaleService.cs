using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Classes;

namespace GameProject_Homework_.Interfaces
{
    interface ISaleService
    {
        void MakeSale(Campaign campaign, double gamePrice);
    }
}
