using GitLabApiClient.Models.Iterations.Responses;

namespace GitLabApiClient.Models.Iterations.Requests
{
    /// <summary>
    /// Options for iteration listing
    /// </summary>
    public sealed class IterationsQueryOptions
    {
        internal IterationsQueryOptions() { }

        /// <summary>
        /// Return only opened, upcoming, current, closed, or all iterations.
        /// </summary>
        public IterationState State { get; set; }

        /// <summary>
        /// Return only iterations with a title matching the provided string.
        /// </summary>
        public string Search { get; set; }
    }
}
