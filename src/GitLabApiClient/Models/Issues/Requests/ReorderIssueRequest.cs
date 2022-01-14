using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Issues.Requests
{
    /// <summary>
    /// Used to reorder issues in a project.
    /// </summary>
    public sealed class ReorderIssueRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReorderIssueRequest"/> class.
        /// </summary>
        public ReorderIssueRequest()
        {

        }

        /// <summary>
        /// The ID of a project’s issue that should be placed after this issue 
        /// </summary>
        [JsonProperty("move_after_id")]
        public int MoveAfterId { get; set; }

        /// <summary>
        /// The ID of a project’s issue that should be placed before this issue 
        /// </summary>
        [JsonProperty("move_before_id")]
        public int MoveBeforeId { get; set; }
    }
}
