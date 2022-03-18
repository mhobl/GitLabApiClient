using System;
using GitLabApiClient.Models.Iterations.Requests;
using GitLabApiClient.Models.Iterations.Responses;

namespace GitLabApiClient.Internal.Queries
{
    internal sealed class IterationsQueryBuilder : QueryBuilder<IterationsQueryOptions>
    {
        protected override void BuildCore(Query query, IterationsQueryOptions options)
        {
            string stateQueryValue = GetStateQueryValue(options.State);
            if (!string.IsNullOrEmpty(stateQueryValue))
                query.Add("state", stateQueryValue);

            if (!string.IsNullOrEmpty(options.Search))
                query.Add("search", options.Search);
        }

        private static string GetStateQueryValue(IterationState state)
        {
            switch (state)
            {
                case IterationState.Opened:
                    return "opened";
                case IterationState.Upcoming:
                    return "upcoming";
                case IterationState.Current:
                    return "current";
                case IterationState.Closed:
                    return "closed";
                case IterationState.All:
                    return "";
                default:
                    throw new NotSupportedException($"State {state} is not supported");
            }
        }
    }
}
