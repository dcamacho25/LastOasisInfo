using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOasisConsoleApp.Models
{
    public class Material
    {
        public string Name { get; set; }
        public string HarvestedWith { get; set; }
        public string[] HarvestedFrom { get; set; }
    }
}
