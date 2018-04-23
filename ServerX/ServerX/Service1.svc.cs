using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace ServerX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // ******** MY FUNCTIONS (CUSTOM ADDED) ******** \\
        Service1()
        {
            this.addUser("Usaid Rahman", "admin", "123", "03322652270");
        }

        // ******** USERDL FUNCTIONS ******** \\
        public void addUser(string name, string email, string password, string phone)
        {
            userDL.addUser(name, email, password, phone);
        }

        public User getUserBYEmail(string email)
        {
            return userDL.getUserBYEmail(email);
        }

        public User getUserBYUsername(string username)
        {
            return userDL.getUserBYUsername(username);
        }

        List<User> getAllUsers()
        {
            return userDL.users;
        }

        int getUsersCount()
        {
            return userDL.users.Count();
        }

        public void addCategory(string c_name)
        {
            categoryDL.addCategory(c_name);
        }

        public List<category> getAllCategories()
        {
            return categoryDL.getAllCategories();
        }
        // ******** USERDL FUNCTIONS END ******** \\

        // ******** MY FUNCTIONS (CUSTOM ADDED):: END ******** \\
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        List<User> IService1.getAllUsers()
        {
            return userDL.users;
        }

        int IService1.getUsersCount()
        {
            return userDL.users.Count();
        }

        public void addRecipe(string title, string author, string date, string url, string desc, List<string> categories)
        {
            recipeDL.addRecipe(title, author, date, url, desc, categories);
        }

        public List<recipe> getRecipes()
        {
            return recipeDL.getRecipes();
        }

        public int getRecipeCount()
        {
            return recipeDL.getRecipeCount();
        }

        public void deleteRecipe(string index)
        {
            recipeDL.deleteRecipe(Int32.Parse(index));
        }

        public recipe getRecipeAT(string index)
        {
            return recipeDL.getRecipeAT(Int32.Parse(index));
        }

        public void generateDietPlan(User user)
        {
            userDL.generateDietPlan(user);
        }

        public void deleteUser(string index)
        {
            userDL.deleteUser(Int32.Parse(index));
        }

        public void deleteCategory(string index)
        {
            categoryDL.deleteCategory(Int32.Parse(index));
        }


        void IService1.updateCategory(string index, string categoryName)
        {
            categoryDL.updateCategory(Int32.Parse(index), categoryName);
        }

        public void updateUser(string index, string name, string email, string password, string phone)
        {
            userDL.updateUser(Int32.Parse(index), name, email, password, phone);
        }

        public void updateRecipe(string index, string title, string author, string date, string url, string desc, List<string> categories)
        {
            recipeDL.updateRecipe(Int32.Parse(index), title, author, date, url, desc, categories);
        }

        public recipe getRandomRecipe()
        {
            return recipeDL.getRandomRecipe();
        }

        public void save_user_settings(User u, string name, string email, string password, string phone, string username)
        {
            userDL.save_user_settings(u, name, email, password, phone, username);
        }
    }
}
