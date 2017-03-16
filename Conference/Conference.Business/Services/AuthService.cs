using Conference.Business.Interfaces;
using Conference.Data.DbContext;
using Conference.Data.Entities;

namespace Conference.Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConferenceDbContextFactory dbFactory;

        public AuthService(IConferenceDbContextFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public bool IsValidUser(string Email, string HashedPassword)
        {
            bool retval = false;
            using (IConferenceDbContext db = dbFactory.Create())
            {
                UserService userService = new UserService(this.dbFactory);
                User user = userService.GetSingleItemByID(Email);
                if (user != null && user.HashedPassword == HashedPassword)
                {
                    retval = true;
                }
            }

            return retval;

        }
    }    
}
