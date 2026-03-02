using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    public class UserManager
    {
        private List _users = new List();

        public void AddUser(string username)
        {
            _users.Add(username);
        }
    }
}
