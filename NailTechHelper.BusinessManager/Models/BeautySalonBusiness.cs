using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace NailTechhelper.BusinessManager
{
    public class BeautySalonBusiness
    {
        [JsonProperty("id")]
       
        public string YelpId { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string BusinessName { get; set; }

        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("url")]
        public string BusinessURL { get; set; }

        [JsonProperty("catigories")]
        public string Category { get; set; }

        [JsonProperty("coordinates")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }


        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }

        [JsonProperty("display_phone")]
        public string PhoneNumberDisplay { get; set; }
    }
}