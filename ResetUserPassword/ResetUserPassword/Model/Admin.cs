using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResetUserPassword.Model
{
    class Admin : User
    {
        public Admin()
        {
            this.setType(UserType.ADMIN);
        }

        public User getUserByUserName(string uName) {
            return Data.Store.getUserByUserName(uName);
        }

        public List<User> getUsersListByFirstAndLastNames(string fName, string lName)
        {
            return Data.Store.getUsersListByFirstAndLastNames(fName, lName);
        }

        public List<User> getAllUsers()
        {
            return Data.Store.getAllUsers();
        }

        public bool resetPassword(User user, string newPassword)
        {
            if (newPassword.Length < 6)
            {
                return false;
            }
            return Data.Store.updateUserPassword(user, newPassword);
        }


       
    }
}
