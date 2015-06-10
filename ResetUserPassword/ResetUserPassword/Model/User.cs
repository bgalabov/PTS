using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetUserPassword.Model
{
    class User
    {
        private int id;
        private string userName;
        private string password;
        private UserType type;
        private string firstName;
        private string secondName;
        private string lastName;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public void setUserName(string uName)
        {
            this.userName = uName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public UserType getType()
        {
            return this.type;
        }

        public void setType(UserType u)
        {
            this.type = u;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string fName)
        {
            this.firstName = fName;
        }

        public string getSecondName()
        {
            return this.secondName;
        }

        public void setSecondName(string sName)
        {
            this.secondName = sName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lName)
        {
            this.lastName = lName;
        } 
    }
}
