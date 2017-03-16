using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Business.Interfaces
{
    public interface IAuthService
    {
        bool IsValidUser(string Email, string HashedPassword);
    }
}
