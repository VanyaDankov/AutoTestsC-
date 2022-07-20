using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.model
{
    public class User
    {
        private string userName;
        private string userPassword;

        public User(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }

        public override string ToString()
        {
            return "username = " + userName + "userPassword = " + userPassword;
        }
    }
}
