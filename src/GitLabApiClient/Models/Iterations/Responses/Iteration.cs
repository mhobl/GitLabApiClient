using System;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Iterations.Responses
{
    public sealed class Iteration : ModifiableObject
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("state")]
        public IterationState State { get; set; }
        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }
}
