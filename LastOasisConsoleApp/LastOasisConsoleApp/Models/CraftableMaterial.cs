using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOasisConsoleApp.Models
{
    public class CraftableMaterial
    {
        public string Name { get; set; }
        public List<CraftingMaterials> CraftingMaterials { get; set; }
        public CraftingStation CraftingStation { get; set; }
    }
}
