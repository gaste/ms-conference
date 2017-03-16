using Conference.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Services
{
    public class ConferenceService : IService<Data.Entities.Conference, Guid>
    {
        public void Add(Data.Entities.Conference newItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Data.Entities.Conference deleteItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Entities.Conference> GetItems()
        {
            throw new NotImplementedException();
        }

        public Data.Entities.Conference GetSingleItemByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Data.Entities.Conference changedItem)
        {
            throw new NotImplementedException();
        }
    }
}
