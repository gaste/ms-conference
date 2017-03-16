using Conference.Business.Providers;
using Conference.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Services
{
    public class AuthService
    {
        bool IsValidUser(string Email, string HashedPassword)
        {
            UserService userService = new UserService();
            User user = userService.GetSingleItemByID(Email);
            if (user!= null && user.HashedPassword == HashedPassword)
            {
                return true;
            }

            return false;
        }
    }    
}
