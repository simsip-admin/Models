using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Types
{
    // TODO: Missing "latest"
    public class MpIm
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool is_mpim { get; set; }
        public bool is_group { get; set; }
        public int created { get; set; }
        public string creator { get; set; }
        public List<string> members { get; set; }
        public string last_read { get; set; }
        public int unread_count { get; set; }
        public int unread_count_display { get; set; }
    }
}
