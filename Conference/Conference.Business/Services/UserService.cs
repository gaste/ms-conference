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
    public class UserService : IService<User, string>
    {
        private IConferenceDbContextFactory factory;

        private UserService() { }
        public UserService(IConferenceDbContextFactory factory) {
            this.factory = factory;
        }

        public void Add(User newItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                db.Users.Add(newItem);
                db.SaveChanges();
            }
        }

        public void Delete(User deleteItem)
        {
            using (IConferenceDbContext db = factory.Create())
            {
                User user = db.Users
                                .Where(u => u.Email == deleteItem.Email)
                                .FirstOrDefault();
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public IEnumerable<User> GetItems()
        {
            IEnumerable<User> users = null;
            using (IConferenceDbContext db = factory.Create())
            {
                users = db.Users;
            }

            return users;
        }
        

        public User GetSingleItemByID(string Email)
        {
            User user = null;
            using (IConferenceDbContext db = factory.Create())
            {                  
                user = db.Users
                    .Where(u => u.Email == Email)
                    .FirstOrDefault(); 
            }

            return user;
        }

        public void Update(User changedItem)
        {
            throw new NotImplementedException();
        }
    }
}
