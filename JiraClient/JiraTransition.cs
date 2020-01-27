using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inflectra.SpiraTest.PlugIns.JiraCloudDataSync.JiraClient
{
    /// <summary>
    /// Represents a JIRA transition
    /// </summary>
    public class JiraTransition : BaseEntity
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public JiraTransitionTo To { get; set; }
    }
}
