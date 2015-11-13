using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Types
{
    public class Reaction
    {
        public string name { get; set; }
        public int count { get; set; }
        public List<string> users { get; set; }
    }
}
