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
            using (IConferenceDbContext db = factory.Create())
            {
                db.Locations.Add(newItem);
                db.SaveChanges();
            }
        }
       

        public void Delete(Location deleteItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                Location location = db.Locations
                                .Where(l => l.LocationId == deleteItem.LocationId)
                                .FirstOrDefault();
                db.Locations.Remove(location);
                db.SaveChanges();
            }
        }

        public IEnumerable<Location> GetItems()
        {
            IEnumerable<Location> locations = null;
            using (IConferenceDbContext db = factory.Create())
            {
                locations = db.Locations;
            }

            return locations;
        }

        public Location GetSingleItemByID(Guid LocationId)
        {
            Location location = null;
            using (IConferenceDbContext db = factory.Create())
            {
                location = db.Locations.Where(l => l.LocationId == LocationId)
                    .FirstOrDefault();
            }

            return location;
        }

        public void Update(Location changedItem)
        {
            throw new NotImplementedException();
        }
    }
}
