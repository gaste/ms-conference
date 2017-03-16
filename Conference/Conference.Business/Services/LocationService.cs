using Conference.Business.Interfaces;
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
        //private ILocationDbContextFactory factory;

            /*
        private LocationService() { }
        public LocationService(ILocationDbContextFactory factory)
        {
            this.factory = factory;
        }
        */

        public void Add(Location newItem)
        {
            /*using (ILocationDbContextFactory db = factory.Create())
            {
                db.Locations.Add(newItem);
                db.SaveChanges();
            }*/
            throw new NotImplementedException();
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
