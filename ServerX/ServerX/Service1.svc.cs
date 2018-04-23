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
            
        }

        public User getUserBYEmail(string email)
        {
            
        }

        public User getUserBYUsername(string username)
        {
            
        }

        List<User> getAllUsers()
        {
            
        }

        int getUsersCount()
        {
            
        }

        public void addCategory(string c_name)
        {
           
        }

        public List<category> getAllCategories()
        {
            
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
            
        }

        int IService1.getUsersCount()
        {
            
        }

        public void addRecipe(string title, string author, string date, string url, string desc, List<string> categories)
        {
            
        }

        public List<recipe> getRecipes()
        {
            
        }

        public int getRecipeCount()
        {
            
        }

        public void deleteRecipe(string index)
        {
            
        }

        public recipe getRecipeAT(string index)
        {
            
        }

        public void generateDietPlan(User user)
        {
            
        }

        public void deleteUser(string index)
        {
            
        }

        public void deleteCategory(string index)
        {
            
        }
        

        void IService1.updateCategory(string index, string categoryName)
        {
            
        }

        public void updateUser(string index, string name, string email, string password, string phone)
        {
            
        }

        public void updateRecipe(string index, string title, string author, string date, string url, string desc, List<string> categories)
        {
            
        }

        public recipe getRandomRecipe()
        {
           
        }
    }
}
