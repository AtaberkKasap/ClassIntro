using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Classes;

namespace GameProject_Homework_.Interfaces
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
