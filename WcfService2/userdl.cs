using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerX
{
    public class userDL
    {
        public static List<User> users = new List<User>();

        // ADD USER 
        public static void addUser(string name, string email, string password, string phone)
        {
            User u = new User();
            u.Name = name;
            u.Email = email;
            u.Password = password;
            u.Phone = phone;
            if (email == "admin")
            {
                u.UserRole = "Admin";
            }
            else
            {
                u.UserRole = "User";
            }
            userDL.users.Add(u);
        }
        // END:: ADD USER

        // RETURN USER OBJECT BY ITS EMAIL
        public static User getUserBYEmail(string email)
        {
            User found = null;
            foreach (User u in userDL.users)
            {
                if (u.Email == email)
                {
                    found = u;
                    break;
                }
            }
            return found;
        }

        // RETURN USER OBJECT BY ITS USERNAME
        public static User getUserBYUsername(string username)
        {
            User found = null;
            foreach (User u in userDL.users)
            {
                if (u.Username == username)
                {
                    found = u;
                    break;
                }
            }
            return found;
        }

    }
}