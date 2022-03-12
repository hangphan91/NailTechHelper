using Microsoft.AspNetCore.Mvc;
using NailTechhelper.BusinessManager;
using NailTechHelper.BusinessManager.Managers;
using NailTechHelper.BusinessManager.Models;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace NailTechHelper.BeautySalonBusiness.Web_Api.Controllers
{
    [Route("BeautySalonBusiness/api")]
    public class BeautySalonBusinessController : ControllerBase
    {

        [HttpGet("business/byId")]
        public ActionResult GetBusinessInfoByYelpId(string yelpId)
        {
            var mgr = new SalonBusinessManager();
           var businessInfo = mgr.GetBeautySalonBusinessByYelpId(yelpId);

            return Ok() ;
            
        }

        [HttpPost("add/businesses")]
        public ActionResult AddBusinesses(BeautySalonBusinessCollection collection)
        {
            var mgr = new SalonBusinessManager();
            mgr.AddBusinesses(collection);

            return Ok();

        }


    }

   
}
