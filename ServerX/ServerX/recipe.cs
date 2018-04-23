using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;

namespace ServerX
{
    public class recipe
    {
        private string title;
        private string author;
        private string video_url;
        private string date;
        private string desc;
        private List<string> categories = new List<string>();
        Stream recipe_thumb;
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

        public Stream Recipe_thumb
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