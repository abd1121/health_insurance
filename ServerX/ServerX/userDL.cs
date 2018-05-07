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
            return users.Count();
        }

        // ADD USER 
        public static void addUser(string name, string email, string password, string phone, string profile)
        {
            if (getUserBYEmail(email) == null)
            {
                User u = new User();
                u.Name = name;
                u.Email = email;
                u.Password = password;
                u.Phone = phone;
                u.UserRole = "User";
                u.UserProfilePic = profile;

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
        }

        public static void addAdmin(string name, string email, string password, string phone)
        {
            if (getUserBYEmail(email) == null)
            {
                User u = new User();
                u.Name = name;
                u.Email = email;
                u.Password = password;
                u.Phone = phone;
                u.UserRole = "User";

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
        }
        // END:: ADD USER

        public static void updateUser(int index, string name, string email, string password, string phone)
        {
            users[index].Name = name;
            users[index].Email = email;
            users[index].Password = password;
            users[index].Phone = phone;
        }

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

        public static void deleteUser(int index)
        {
            users.RemoveAt(index);
        }

        public static User generateDietPlan(User user)
        {
            Random r = new Random();
            List<recipe> random_recpies = new List<recipe>();

            for (int i = 0; i < 7; i++)
            {
                int rnd = r.Next(0, recipeDL.recipes.Count());
                random_recpies.Add(recipeDL.recipes[rnd]);
            }

            user.DietPlan = new dietPlan();
            user.DietPlan.Monday = random_recpies[0];
            user.DietPlan.Tuesday = random_recpies[1];
            user.DietPlan.Wednesday = random_recpies[2];
            user.DietPlan.Thursday = random_recpies[3];
            user.DietPlan.Friday = random_recpies[4];
            user.DietPlan.Saturday = random_recpies[5];
            user.DietPlan.Sunday = random_recpies[6];

            foreach(User u in users)
            {
                if(u.Email == user.Email && u.Password == user.Password)
                {
                    u.DietPlan = user.DietPlan;
                }
            }
            return user;
        }

        public static void save_user_settings(User u, string name, string email, string password, string phone, string username) {
            foreach(User user in users) {
                if(user.Email == email && user.Password == password) {
                    user.Name = name;
                    user.Email = email;
                    user.Password = password;
                    user.Phone = phone;
                    user.Username = username;
                    break;
                }
            }
        }
    }
}