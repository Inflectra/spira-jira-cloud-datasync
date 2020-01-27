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
    /// Represents the issue transition meta-data (which transitions are available)
    /// </summary>
    public class JiraTransitionMetaData
    {
        [JsonProperty("transitions", NullValueHandling = NullValueHandling.Ignore)]
        public JiraTransition[] Transitions { get; set; }
    }
}
