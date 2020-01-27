using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inflectra.SpiraTest.PlugIns.JiraCloudDataSync.JiraClient
{
    /// <summary>
    /// Represents the issue edit meta-data (which fields are available)
    /// </summary>
    public class JiraEditMetaData
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Fields { get; set; }
    }
}
