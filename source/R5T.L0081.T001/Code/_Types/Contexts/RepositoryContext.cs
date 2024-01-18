using System;

using Octokit;

using R5T.L0078.T000;
using R5T.T0137;
using R5T.T0235.T000;


namespace R5T.L0081.T001
{
    [ContextImplementationMarker, ContextTypeMarker]
    public class RepositoryContext :
        IWithRepositoryName,
        IWithRepositoryOwnerName,
        IWithGitHubClient
    {
        public string RepositoryName { get; set; }
        public string RepositoryOwnerName { get; set; }
        public GitHubClient GitHubClient { get; set; }
    }
}
