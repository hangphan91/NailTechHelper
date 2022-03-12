using NailTechHelper.BusinessManager.ExternalCalls;
using NailTechHelper.BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NailTechHelper.BusinessManager.Managers
{
    public class YelpFusionManager
    {
        public async Task<BeautySalonBusinessCollection> GetBusinessInfoFromSearchBy(string term, string location, int limit)
        {
            var yelpDa = new YelpFusionDa();

            var businesses = await yelpDa.GetBusinessesInfoFromYelpAsync(term, location, limit);

            return businesses;
        }
    }
}
