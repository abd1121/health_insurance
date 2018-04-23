using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Drawing;
using System.IO;

namespace ServerX
{
    public class User : usersParent
    {
        private dietPlan dietPlan;

        [DataMemberAttribute]
        public dietPlan DietPlan
        {
            get
            {
                return dietPlan;
            }

            set
            {
                dietPlan = value;
            }
        }
    }
}