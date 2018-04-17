using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class userDL
    {
        public static List<User> usersData = new List<User>();

        public static void addUser(string name, string email, string password, string phone)
        {
            
        }
        // END:: ADD USER

        // RETURN USER OBJECT BY ITS EMAIL
        public static User getUserBYEmail(string email)
        {
            
        }

        // RETURN USER OBJECT BY ITS USERNAME
        public static User getUserBYUsername(string username)
        {
           
        }
    }
}