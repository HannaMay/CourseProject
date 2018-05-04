using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_WPF.Model
{
    class User
    {
        //Variablen
        private string name;
        private string username;
        private string email;
        private string password;
        private string confpassword;

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Confpassword
        {
            get
            {
                return password;
            }
            set
            {
                value = confpassword;
                confpassword = Password;
            }
        }

        //Constructors
        public User(string name, string username, string password, string email)
        {
            name = Name;
            username = UserName;
            email = Email;
            password = Password;

        }
        public User(string username, string password)
        {
            username = UserName;
            password = Password;
        }

    }
}
