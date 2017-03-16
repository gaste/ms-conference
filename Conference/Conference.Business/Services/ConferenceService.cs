using Conference.Business.Interfaces;
using Conference.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Services
{
    public class ConferenceService : IService<Data.Entities.Conference, Guid>
    {
        private IConferenceDbContextFactory factory;

        private ConferenceService() { }
        public ConferenceService(IConferenceDbContextFactory factory)
        {
            this.factory = factory;
        }

        public void Add(Data.Entities.Conference newItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                db.Conferences.Add(newItem);
                db.SaveChanges();
            }
        }

        public void Delete(Data.Entities.Conference deleteItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                Data.Entities.Conference conference = db.Conferences
                                .Where(c => c.ConferenceId == deleteItem.ConferenceId)
                                .FirstOrDefault();
                db.Conferences.Remove(conference);
                db.SaveChanges();
            }
        }

        public IEnumerable<Data.Entities.Conference> GetItems()
        {
            IEnumerable<Data.Entities.Conference> conferences = null;
            using (IConferenceDbContext db = factory.Create())
            {
                conferences = db.Conferences;
            }

            return conferences;
        }

        public Data.Entities.Conference GetSingleItemByID(Guid conferenceId)
        {
            Data.Entities.Conference conference = null;
            using (IConferenceDbContext db = factory.Create())
            {
                conference = db.Conferences.Where(l => l.ConferenceId == conferenceId)
                    .FirstOrDefault();
            }

            return conference;
        }

        public void Update(Data.Entities.Conference changedItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                Data.Entities.Conference conference = db.Conferences.Where(l => l.ConferenceId == changedItem.ConferenceId)
                    .FirstOrDefault();

                conference.Abstract = changedItem.Abstract;
                conference.AmountOfLastingDays = changedItem.AmountOfLastingDays;
                conference.Location = changedItem.Location;
                conference.StartsAt = changedItem.StartsAt;
                conference.Title = changedItem.Title;

                db.SaveChanges();
            }
        }
    }
}
