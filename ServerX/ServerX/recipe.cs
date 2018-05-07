using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

namespace ServerX
{
    [Serializable]
    [DataContractAttribute(IsReference = true)]
    public class recipe
    {
        private string title;
        private string author;
        private string video_url;
        private string date;
        private string desc;
        private List<string> categories = new List<string>();
        string recipe_thumb;

        [DataMemberAttribute]
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        [DataMemberAttribute]
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        [DataMemberAttribute]
        public string Video_url
        {
            get
            {
                return video_url;
            }

            set
            {
                video_url = value;
            }
        }

        [DataMemberAttribute]
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        [DataMemberAttribute]
        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        [DataMemberAttribute]
        public List<string> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }

        [DataMemberAttribute]
        public string Recipe_thumb
        {
            get
            {
                return recipe_thumb;
            }

            set
            {
                recipe_thumb = value;
            }
        }
    }
}