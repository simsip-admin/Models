using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Types
{
    // TODO: Pinned item
    public class Message
    {
        public string type { get; set; }
        public string subtype { get; set; }
        public string channel { get; set; }
        public string user { get; set; }
        public string text { get; set; }
        public string ts { get; set; }
        public List<Attachment> attachments { get; set; }
        public Edited edited { get; set; }
        public Message message { get; set; }
        public Channel Channel { get; set; }
        public Group group { get; set; }
        public File file { get; set; }
        public bool hidden { get; set; }
        public string deleted_ts { get; set; }
        public string event_ts { get; set; }

        public bool is_starred { get; set; }

        public List<string> pinned_to { get; set; }

        List<Reaction> reactions { get; set; }
    }
}
