using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerX
{
    public class offer
    {
        private string name;
        private string phone;
        private string email;
        private string longitude;
        private string altitude;
        recipe menu;

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

        public string Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public string Altitude
        {
            get
            {
                return altitude;
            }

            set
            {
                altitude = value;
            }
        }

        public recipe Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }
    }
}