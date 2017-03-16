using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Conference.Presentation.Classes
{
    public class CLogin
    {
        private string _email;
        private string _passwd;
        private string _name;
        private string _vorName;

        public CLogin (string email, string passwd)
        {
            _email = email;
            _passwd = passwd;
            _name = string.Empty;
            _vorName = string.Empty;
        }

        public bool IsValid()
        {
            // Anfrage an Service
            return true;
        }

        public static bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email,
              @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

    }
}

