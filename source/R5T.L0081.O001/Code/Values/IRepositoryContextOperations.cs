using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Octokit;

using R5T.L0081.T001;
using R5T.T0131;
using R5T.T0235.T000;


namespace R5T.L0081.O001
{
    /// <summary>
    /// Repository operations based on:
    /// <list type="bullet">
    /// <item><see cref="IHasRepositoryName"/></item>
    /// <item><see cref="IHasRepositoryOwnerName"/></item>
    /// </list>
    /// </summary>
    [ValuesMarker]
    public partial interface IRepositoryContextOperations : IValuesMarker
    {
        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            IEnumerable<Func<RepositoryContext, Task>> operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return context =>
            {
                var childContext = new RepositoryContext
                {
                    RepositoryName = context.RepositoryName,
                    RepositoryOwnerName = context.RepositoryOwnerName,
                    //GitHubClient // Do not set, rely on outer operations.
                };

                return Instances.ContextOperator.In_Context(
                    childContext,
                    operations);
            };
        }

        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            params Func<RepositoryContext, Task>[] operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return this.In_GitHubClientContext<TContext>(
                operations.AsEnumerable());
        }

        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            Task<GitHubClient> gettingGitHubClient,
            IEnumerable<Func<RepositoryContext, Task>> operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return async context =>
            {
                var gitHubClient = await gettingGitHubClient;

                var childContext = new RepositoryContext
                {
                    GitHubClient = gitHubClient,
                    RepositoryName = context.RepositoryName,
                    RepositoryOwnerName = context.RepositoryOwnerName,
                };

                await Instances.ContextOperator.In_Context(
                    childContext,
                    operations);
            };
        }

        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            Task<GitHubClient> gettingGitHubClient,
            params Func<RepositoryContext, Task>[] operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return this.In_GitHubClientContext<TContext>(
                gettingGitHubClient,
                operations.AsEnumerable());
        }

        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            GitHubClient gitHubClient,
            IEnumerable<Func<RepositoryContext, Task>> operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return this.In_GitHubClientContext<TContext>(
                Task.FromResult(gitHubClient),
                operations);
        }

        public Func<TContext, Task> In_GitHubClientContext<TContext>(
            GitHubClient gitHubClient,
            params Func<RepositoryContext, Task>[] operations)
            where TContext : IHasRepositoryOwnerName, IHasRepositoryName
        {
            return this.In_GitHubClientContext<TContext>(
                gitHubClient,
                operations.AsEnumerable());
        }

        
    }
}
