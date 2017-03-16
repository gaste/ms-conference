using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference.Data.Entities
{
    public class Conference
    {
        public Conference(string title, string confAbstract, DateTime startsAt, int amountOfLastingDays, User lecturer)
            : this(title, confAbstract, startsAt, amountOfLastingDays, lecturer, Enumerable.Empty<User>())
        { }

        public Conference(string title, string confAbstract, DateTime startsAt, int amountOfLastingDays, User lecturer, IEnumerable<User> attendees)
        {
            this.Title = title;
            this.Abstract = confAbstract;
            this.StartsAt = startsAt;
            this.AmountOfLastingDays = amountOfLastingDays;
            this.Lecturer = lecturer;
            this.Attendees = new List<User>(attendees);
        }

        public string Title { get; set; }
        public string Abstract { get; set; }
        public DateTime StartsAt { get; set; }
        public int AmountOfLastingDays { get; set; }
        public Location Location { get; set; }
        public User Lecturer { get; private set; }
        public ICollection<User> Attendees { get; private set; }
    }
}
