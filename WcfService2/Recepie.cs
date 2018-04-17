using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Recepie
    {
        private String title;
        private String author;
        private String date;
        private String video_url;
        private string detail;
        public static List<String> ingredients = new List<string>();
        public static List<String> nutritions = new List<string>();
        private String category;

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

        public string Detail
        {
            get
            {
                return detail;
            }

            set
            {
                detail = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
    }
}