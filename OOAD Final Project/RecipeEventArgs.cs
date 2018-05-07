using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Final_Project
{
    public class RecipeEventArgs: EventArgs
    {
        public server.recipe Recipe { get; set; }
    }
}
