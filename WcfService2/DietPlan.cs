using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class DietPlan
    {
        private Recepie monday;
        private Recepie tuesday;
        private Recepie wednesday;
        private Recepie thursday;
        private Recepie friday;
        private Recepie saturday;
        private Recepie sunday;

        public Recepie Monday
        {
            get
            {
                return monday;
            }

            set
            {
                monday = value;
            }
        }

        public Recepie Tuesday
        {
            get
            {
                return tuesday;
            }

            set
            {
                tuesday = value;
            }
        }

        public Recepie Wednesday
        {
            get
            {
                return wednesday;
            }

            set
            {
                wednesday = value;
            }
        }

        public Recepie Thursday
        {
            get
            {
                return thursday;
            }

            set
            {
                thursday = value;
            }
        }

        public Recepie Friday
        {
            get
            {
                return friday;
            }

            set
            {
                friday = value;
            }
        }

        public Recepie Saturday
        {
            get
            {
                return saturday;
            }

            set
            {
                saturday = value;
            }
        }

        public Recepie Sunday
        {
            get
            {
                return sunday;
            }

            set
            {
                sunday = value;
            }
        }
    }
}