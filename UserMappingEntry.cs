using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inflectra.SpiraTest.PlugIns.JiraCloudDataSync
{
    /// <summary>
    /// Represents the mapping between a Spira user and a Jira user
    /// </summary>
    public class UserMappingEntry
    {
        /// <summary>
        /// The id of the user in Spira
        /// </summary>
        public int SpiraUserId
        {
            get;
            set;
        }

        /// <summary>
        /// The GUID of the user in Jira
        /// </summary>
        /// <remarks>
        /// This is always returned but is just a GUID
        /// </remarks>
        public string JiraAccountId
        {
            get;
            set;
        }

        /// <summary>
        /// The email address of the user in Jira (also their login)
        /// </summary>
        /// <remarks>
        /// This is the email address of the user, but may be null depending on privacy settings
        /// </remarks>
        public string JiraEmailAddress
        {
            get;
            set;
        }
    }
}
