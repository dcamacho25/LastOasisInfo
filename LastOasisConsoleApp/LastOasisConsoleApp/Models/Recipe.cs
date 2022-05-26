using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOasisConsoleApp.Models
{
    public class Recipe
    {
        public List<Material> MatsNeeded { get; set; }
        public List<CraftableMaterial> CraftableMaterialsNeeded { get; set; }
    }
}
