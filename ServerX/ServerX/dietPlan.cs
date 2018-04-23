using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace ServerX
{
    public class dietPlan
    {
        private recipe monday;
        private recipe tuesday;
        private recipe wednesday;
        private recipe thursday;
        private recipe friday;
        private recipe saturday;
        private recipe sunday;

        [DataMemberAttribute]
        public recipe Monday
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

        public recipe Tuesday
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

        public recipe Wednesday
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

        public recipe Thursday
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

        public recipe Friday
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

        public recipe Saturday
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

        public recipe Sunday
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