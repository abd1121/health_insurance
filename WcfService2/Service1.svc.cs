using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServerX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // ******** MY FUNCTIONS (CUSTOM ADDED) ******** \\

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
    }
}
