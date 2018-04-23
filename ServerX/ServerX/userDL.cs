using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerX
{
    [Serializable]
    [DataContractAttribute(IsReference = true)]
    public class userDL
    {
        public static List<User> users = new List<User>();

        // To Get Total Number Of Users
        public int getCount()
        {
            
        }
        
        // ADD USER 
        public static void addUser(string name, string email, string password, string phone)
        {
            
        }
        // END:: ADD USER

        public static void updateUser(int index, string name, string email, string password, string phone)
        {
            
        }

        // RETURN USER OBJECT BY ITS EMAIL
        public static User getUserBYEmail(string email)
        {
            
        }

        // RETURN USER OBJECT BY ITS USERNAME
        public static User getUserBYUsername(string username)
        {
            
        }

        public static void deleteUser(int index)
        {
            
        }

        public static void generateDietPlan(User user)
        {
            
        }
    }
}