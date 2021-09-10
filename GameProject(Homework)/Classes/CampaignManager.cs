using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject_Homework_.Interfaces;

namespace GameProject_Homework_.Classes
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine($"Sisteme {campaign.CampaignName} kampanyası eklendi.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} kampanyası sona erdi.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} isimli kampanya güncellendi.");
        }
    }
}
