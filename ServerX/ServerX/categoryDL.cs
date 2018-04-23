using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerX
{
    public class categoryDL
    {
        public static List<category> categories = new List<category>();

        public static void addCategory(string c_name)
        {
            category c = new category();
            c.Category_name = c_name;
            categories.Add(c);
        }

        public static List<category> getAllCategories()
        {
            return categories;
        }

        public static void deleteCategory(int index)
        {
            categories.RemoveAt(index);
        }

        public static void updateCategory(int index, string categoryName)
        {
            categories[index].Category_name = categoryName;
        }
    }
}