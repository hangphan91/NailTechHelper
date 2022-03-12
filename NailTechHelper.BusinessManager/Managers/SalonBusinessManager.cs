using NailTechHelper.BusinessManager.Models;
using NailTechHelper.Data.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace NailTechhelper.BusinessManager
{
    public class SalonBusinessManager
    {
        public BeautySalonBusiness GetBeautySalonBusinessByYelpId(string yelpId)
        {
            var foundBusiness = new NailTechHelper.Data.Definitions.Models.BeautySalonBusiness();
            using (var da = new OperationDa())
            {
                foundBusiness = da.GetBussinessById(yelpId);

            }

            BeautySalonBusiness result = MapSalonBusinessResult(foundBusiness);

            return result;
        }

        public void AddBusinesses(BeautySalonBusinessCollection collection)
        {
            var businesses = new List<NailTechHelper.Data.Definitions.Models.BeautySalonBusiness>();

            foreach (var business in collection.BeautySalonBusinesses)
            {
                var businessInfo = new NailTechHelper.Data.Definitions.Models.BeautySalonBusiness
                {
                    Address1 = business.Location?.Address1,
                    Address2 = business.Location?.Address2,
                    Address3 = business.Location?.Address3,
                    Alias = business.Alias,
                    DisplayAddress1 = business.Location?.DisplayAddresses?.FirstOrDefault(),
                    DisplayAddress2 = business.Location?.DisplayAddresses?.FirstOrDefault(),
                    BusinessName = business.BusinessName,
                    BusinessURL = business.BusinessURL,
                    Category =  business.Category,
                    City = business.Location?.City,
                    Country = business.Location?.Country,
                    ImageURL =  business.ImageURL,
                    Latitude = business.Coordinate?.Latitude,
                    Longitude = business.Coordinate?.Longitude,
                    PhoneNumber = business.PhoneNumber,
                    PhoneNumberDisplay = business.PhoneNumberDisplay,
                    Price = business.Price,
                    State = business.Location?.State,
                    YelpId = business.YelpId,
                    ZipCode = business.Location.ZipCode

                };
                businesses.Add(businessInfo);
            }

            if (!businesses.Any())
                return;


            using (var da = new OperationDa())
            {
                da.AddBusinesses(businesses);
            }
        }

        private static BeautySalonBusiness MapSalonBusinessResult(NailTechHelper.Data.Definitions.Models.BeautySalonBusiness foundBusiness)
        {
            if (foundBusiness == null)
                return new BeautySalonBusiness();
            return new BeautySalonBusiness
            {
                Alias = foundBusiness.Alias,
                
                BusinessName = foundBusiness.BusinessName,
                BusinessURL = foundBusiness.BusinessURL,
                Category = foundBusiness.Category,
                Coordinate = new Coordinate
                {
                    Latitude = foundBusiness.Latitude,
                    Longitude = foundBusiness.Longitude
                },
                ImageURL = foundBusiness.ImageURL,
                Location = new Location
                {
                    Address1 = foundBusiness.Address1,
                    Address2 = foundBusiness.Address2,
                    Address3 = foundBusiness.Address3,
                    City = foundBusiness.City,
                    Country = foundBusiness.Country,
                    State = foundBusiness.State,
                    ZipCode = foundBusiness.ZipCode,
                    DisplayAddresses = new System.Collections.Generic.List<string>
                    {
                        foundBusiness.DisplayAddress1,
                        foundBusiness.DisplayAddress2
                    },
                },
                PhoneNumber = foundBusiness.PhoneNumber,
                PhoneNumberDisplay = foundBusiness.PhoneNumberDisplay,
                Price = foundBusiness.Price,
                YelpId = foundBusiness.YelpId
            };
        }

    }
}