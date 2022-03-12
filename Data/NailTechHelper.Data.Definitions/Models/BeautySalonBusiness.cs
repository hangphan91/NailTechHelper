using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NailTechHelper.Data.Definitions.Models
{
    public class BeautySalonBusiness
    {
        public long Id { get; set; }
        [MaxLength(50)]
        public string YelpId { get; set; }

        [MaxLength(500)]
        public string Alias { get; set; }

        [MaxLength(1000)]
        public string BusinessName { get; set; }

        [MaxLength(1000)]
        public string ImageURL { get; set; }

        [MaxLength(1000)]
        public string BusinessURL { get; set; }

        [MaxLength(200)]
        public string Category { get; set; }

        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        [MaxLength(50)]
        public string  Price { get; set; }

        [MaxLength(1000)]
        public string Address1 { get; set; }

        [MaxLength(1000)]
        public string Address2 { get; set; }

        [MaxLength(1000)]
        public string Address3 { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(50)]
        public string ZipCode { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(1000)]
        public string DisplayAddress1 { get; set; }

        [MaxLength(1000)]
        public string DisplayAddress2 { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string PhoneNumberDisplay { get; set; }

    }
}
