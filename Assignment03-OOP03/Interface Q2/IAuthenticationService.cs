using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_OOP03.Interface_Q2
{
    interface IAuthenticationService
    {
        public bool AuthenticateUser(string username,string password);

        public bool AuthorizeUser(string username,string role);
    }
}
