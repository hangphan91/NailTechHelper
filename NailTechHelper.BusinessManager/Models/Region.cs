using NailTechhelper.BusinessManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NailTechHelper.BusinessManager.Models
{
    public class Region
    {
        [JsonProperty("center")]
        public Coordinate Coordinate { get; set; }
    }
}
