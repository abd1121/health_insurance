using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class User
    {
        private string name;
        private string email;
        private string phone;
        private string username;
        private string password;
        private String diet_type;
        private DietPlan dietplan;

        // FOR GENERATING DIET PLAN
        DietPlan generatDietplan() {
            
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Diet_type
        {
            get
            {
                return diet_type;
            }

            set
            {
                diet_type = value;
            }
        }

        public DietPlan Dietplan
        {
            get
            {
                return dietplan;
            }

            set
            {
                dietplan = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}