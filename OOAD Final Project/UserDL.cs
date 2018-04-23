using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Final_Project
{
    class UserDL
    {
        public static List<User> users = new List<User>();

        public static void addUser(User u)
        {
            users.Add(u);
        }

        //FUNCTION TO GET USER BY EMAIL
        public static User getUserBYEmail(String email)
        {
            User found = null;
            foreach(User u in users)
            {
                if(u.Email == email)
                {
                    found = u;
                    break;
                }
            }
            return found;
        }

        //FUNCTION TO GET USER BY USERNAME
        public static User getUserBYUsername(String username)
        {
            User found = null;
            foreach (User u in users)
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
