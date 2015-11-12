using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;


namespace Models.Models
{
    public class ChannelList
    {
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public IList<Channel> Channels { get; set; }
    }
}
