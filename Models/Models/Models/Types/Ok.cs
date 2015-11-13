using Newtonsoft.Json;
using System.ComponentModel;

namespace Models.Models.Types
{

    public class Ok
    {
        [JsonProperty(PropertyName="ok")]
        public bool OK { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }
    }
}
