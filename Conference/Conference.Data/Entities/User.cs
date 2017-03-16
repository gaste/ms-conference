using System.Collections.Generic;
using System.Linq;

namespace Conference.Data.Entities
{
    public class User
    {
        public User(string name, string firstName, string email, string hashedPassword)
            : this(name, firstName, email, hashedPassword, Enumerable.Empty<Conference>(), Enumerable.Empty<Conference>())
        { }

        public User(string name, string firstName, string email, string hashedPassword, IEnumerable<Conference> holdsConferences, IEnumerable<Conference> enrolledConferences)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Email = email;
            this.HashedPassword = hashedPassword;
            this.HoldsConferences = new List<Conference>(holdsConferences);
            this.EnrolledConferences = new List<Conference>(enrolledConferences);
        }

        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public string Email { get; private set; }
        public string HashedPassword { get; private set; }
        public ICollection<Conference> HoldsConferences { get; private set; }
        public ICollection<Conference> EnrolledConferences { get; private set; }
    }
}
