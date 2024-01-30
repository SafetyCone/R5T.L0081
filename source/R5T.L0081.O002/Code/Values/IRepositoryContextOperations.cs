using System;
using System.Threading.Tasks;

using R5T.L0078.T000;
using R5T.T0131;
using R5T.T0235.T000;


namespace R5T.L0081.O002
{
    /// <summary>
    /// Repository context operations based on:
    /// <list type="bullet">
    /// <item><see cref="IHasRepositoryName"/></item>
    /// <item><see cref="IHasRepositoryOwnerName"/></item>
    /// <item><see cref="IHasGitHubClient"/></item>
    /// <item><see cref="IHasRepository"/></item>
    /// </list>
    /// </summary>
    [ValuesMarker]
    public partial interface IRepositoryContextOperations : IValuesMarker
    {
        public async Task Get_Repository<TContext>(TContext context)
            where TContext : IHasRepositoryName, IHasRepositoryOwnerName, IHasGitHubClient, IWithRepository
        {
            context.Repository = await Instances.GitHubClientOperator.Get_Repository(
                context.GitHubClient,
                context.RepositoryOwnerName,
                context.RepositoryName);
        }
    }
}
