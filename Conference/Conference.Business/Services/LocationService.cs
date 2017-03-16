using Conference.Business.Interfaces;
using Conference.Data.DbContext;
using Conference.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Services
{
    public class LocationService : IService<Location, Guid>
    {
        private IConferenceDbContextFactory factory;
                
        private LocationService() { }
        public LocationService(IConferenceDbContextFactory factory)
        {
            this.factory = factory;
        }

        public void Add(Location newItem)
        {
            /*using (IConferenceDbContextFactory db = factory.Create())
            {
                db.Locations.Add(newItem);
                db.SaveChanges();
            }*/
        }
       

        public void Delete(Location deleteItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetItems()
        {
            throw new NotImplementedException();
        }

        public Location GetSingleItemByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Location changedItem)
        {
            throw new NotImplementedException();
        }
    }
}
