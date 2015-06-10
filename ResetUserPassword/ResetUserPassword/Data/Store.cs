using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ResetUserPassword.Model;

namespace ResetUserPassword.Data
{
    class Store
    {
        public static List<User> usersList = new List<User>();
        

        public static void insertUser(User u) {
            usersList.Add(u);
        }

        public static bool updateUserPassword(User u, string newPassword)
        {
            foreach (User user in usersList)
                {
                    if (user.getId() == u.getId())
                    {
                        user.setPassword(newPassword);
                        return true;
                    }
                }
                return false;
        }

        public static User getUserByUserName(string uName)
        {
            foreach (User user in usersList)
            {
                if (user.getUserName().Equals(uName))
                {
                    return user;
                }
            }
            return null;
        }

        public static List<User> getUsersListByFirstAndLastNames(string fName, string lName)
        {
            List<User> matchedUsersList = new List<User>();
            foreach (User user in usersList)
            {
                if (user.getFirstName().Equals(fName))
                {
                    if (user.getLastName().Equals(lName))
                    {
                        matchedUsersList.Add(user);
                    }
                }
            }
            if (matchedUsersList.Count == 0)
            {
                return null;
            }
            return matchedUsersList;
        }

        public static List<User> getAllUsers()
        {
            return usersList;
        }

        
    }
}
