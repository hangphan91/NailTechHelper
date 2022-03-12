using NailTechHelper.Data.Definitions.Models;
using NailTechHelper.Data.Persistence.DataAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NailTechHelper.Data.Persistence
{
    public class OperationDa : IDisposable
    {
        public DataContext  _dataContext { get; set; }
        public OperationDa()
        {
            _dataContext = new DataContext();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public BeautySalonBusiness GetBussinessById(string yelpId)
        {
            return _dataContext.BeautySalonBussinesses.Where(b => b.YelpId.Equals(yelpId)).FirstOrDefault();
        }

        public bool AddBusinesses(List<BeautySalonBusiness> businesses)
        {

            var yelpIds = _dataContext.BeautySalonBussinesses.Select(salons => salons.YelpId);

            var businessesToSave = businesses.Where(b => !yelpIds.Contains(b.YelpId));

            _dataContext.BeautySalonBussinesses.AddRange(businessesToSave);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
