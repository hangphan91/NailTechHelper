using Microsoft.AspNetCore.Mvc;
using NailTechHelper.BusinessManager.Managers;
using NailTechHelper.BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NailTechHelper.BeautySalonBusiness.Web_Api.Controllers
{
    [Route("YelpFusion")]
    public class YelpFusionController : ControllerBase
    {
        [HttpGet("api/YelpFusion/business/search")]
        public async Task<ActionResult> GetBusinessInfoFromSearchBy(string term = "nail salon",
            string location = "Fort Smith Arkansas", int limit = 50)
        {
            var mgr = new YelpFusionManager();
            var businessInfos = await mgr.GetBusinessInfoFromSearchBy(term, location, limit);

            var businessController = new BeautySalonBusinessController();
            businessController.AddBusinesses(businessInfos);

            return Ok();
        }
    }
}
