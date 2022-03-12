using NailTechhelper.BusinessManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NailTechHelper.BusinessManager.Models
{
    public class BeautySalonBusinessCollection
    {
        [JsonProperty("businesses")]
        public List<BeautySalonBusiness> BeautySalonBusinesses { get; set; }
       
        
        [JsonProperty("region")]
        public  Region Region { get; set; }
    }
}
