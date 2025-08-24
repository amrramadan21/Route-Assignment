using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_OOP03.Interface_Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string ValidUsername = "admin";
        private readonly string ValidPassword = "1234";

        //public BasicAuthenticationService(string username,string password)
        //{
        //    ValidUsername = username;
        //    ValidPassword = password;
        //}

        public bool AuthenticateUser(string username, string password)
        {
            return string.Equals(username, ValidUsername, StringComparison.OrdinalIgnoreCase) 
                && string.Equals(password, ValidPassword, StringComparison.OrdinalIgnoreCase);

        }

        public bool AuthorizeUser(string username, string role)
        {
            if (string.Equals(username,ValidUsername,StringComparison.OrdinalIgnoreCase) && role == "Administrator")
            {
                return true;
            }
            return false;
        }



    }
}
