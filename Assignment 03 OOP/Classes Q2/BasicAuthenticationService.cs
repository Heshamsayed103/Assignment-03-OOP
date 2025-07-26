using Assignment_03_OOP.Interfaces_Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Classes_Q2
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, (string Password, string Role)> users;

        public BasicAuthenticationService()
        {
            users = new Dictionary<string, (string, string)>()
        {
            { "admin", ("admin123", "Admin") },
            { "user", ("user123", "User") }
        };
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].Password == password)
                return true;

            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (users.ContainsKey(username) && users[username].Role == role)
                return true;

            return false;
        }
    }

}
