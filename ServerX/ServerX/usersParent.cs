using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace ServerX
{
    [Serializable]
    [DataContractAttribute(IsReference = true)]

    public class usersParent
    {
        private string name;
        private string email;
        private string phone;
        private string username;
        private string password;
        private string userRole;
        private Image userProfilePic;

        [DataMemberAttribute]
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

        [DataMemberAttribute]
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

        [DataMemberAttribute]
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

        [DataMemberAttribute]
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

        [DataMemberAttribute]
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

        [DataMemberAttribute]
        public string UserRole
        {
            get
            {
                return userRole;
            }

            set
            {
                userRole = value;
            }
        }

        [DataMemberAttribute]
        public Image UserProfilePic
        {
            get
            {
                return userProfilePic;
            }

            set
            {
                userProfilePic = value;
            }
        }
    }
}