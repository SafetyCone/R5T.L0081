using System;
using System.Threading.Tasks;

using R5T.L0078.T000;
using R5T.L0079;
using R5T.L0091.T000;
using R5T.T0131;
using R5T.T0221;
using R5T.T0235.T000;


namespace R5T.L0081.O002
{
    /// <summary>
    /// GitHub client context operations based on:
    /// <list type="bullet">
    /// <item><see cref="IHasRepositoryName"/></item>
    /// <item><see cref="IHasRepositoryOwnerName"/></item>
    /// <item><see cref="IHasGitHubClient"/></item>
    /// </list>
    /// </summary>
    [ValuesMarker]
    public partial interface IGitHubClientContextOperations : IValuesMarker,
        L0078.O001.IGitHubClientContextOperations
    {
        /// <inheritdoc cref="IGitHubOperator.Create_Repository_NonIdempotent(Octokit.GitHubClient, RepositorySpecification)"/>
        public Func<TRepositoryContext, Task> Create_Repository_NonIdempotent<TRepositoryContext, TGitHubContext>(
            TGitHubContext gitHubContext,
            (IsSet<IHasGitHubClient> GitHubClientSet, IsSet<IHasRepositorySpecification> RepositorySpecificiationSet) propertiesRequired,
            out IsSet<IHasRepository> propertiesSet,
            out IChecked<IGitHubRepositoryExists> @checked)
            where TGitHubContext:
            IHasGitHubClient
            where TRepositoryContext :
            IWithRepository,
            IHasRepositorySpecification
        {
            @checked = Checked.Check<IGitHubRepositoryExists>();

            return async context =>
            {
                context.Repository = await Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    gitHubContext.GitHubClient,
                    context.RepositorySpecification);
            };
        }

        /// <inheritdoc cref="IGitHubOperator.Create_Repository_NonIdempotent(Octokit.GitHubClient, RepositorySpecification)"/>
        public Func<TRepositoryContext, TGitHubContext, Task> Create_Repository_NonIdempotent<TRepositoryContext, TGitHubContext>(
            (IsSet<IHasGitHubClient> GitHubClientSet, IsSet<IHasRepositorySpecification> RepositorySpecificiationSet) propertiesRequired,
            out IsSet<IHasRepository> propertiesSet,
            out IChecked<IGitHubRepositoryExists> @checked)
            where TGitHubContext :
            IHasGitHubClient
            where TRepositoryContext :
            IWithRepository,
            IHasRepositorySpecification
        {
            @checked = Checked.Check<IGitHubRepositoryExists>();

            return async (repositoryContext, gitHubContext) =>
            {
                repositoryContext.Repository = await Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    gitHubContext.GitHubClient,
                    repositoryContext.RepositorySpecification);
            };
        }

        /// <inheritdoc cref="IGitHubOperator.Create_Repository_NonIdempotent(Octokit.GitHubClient, RepositorySpecification)"/>
        public Func<TContext, Task> Create_Repository_NonIdempotent<TContext>(
            (IsSet<IHasGitHubClient> GitHubClientSet, IsSet<IHasRepositorySpecification> RepositorySpecificiationSet) propertiesRequired,
            out IsSet<IHasRepository> propertiesSet,
            out IChecked<IGitHubRepositoryExists> @checked)
            where TContext : IHasGitHubClient, IWithRepository, IHasRepositorySpecification
        {
            @checked = Checked.Check<IGitHubRepositoryExists>();

            return async context =>
            {
                context.Repository = await Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    context.GitHubClient,
                    context.RepositorySpecification);
            };
        }

        /// <inheritdoc cref="IGitHubOperator.Create_Repository_NonIdempotent(Octokit.GitHubClient, RepositorySpecification)"/>
        public Func<TContext, Task> Create_Repository_NonIdempotent_I01<TContext>(
            RepositorySpecification repositorySpecification)
            where TContext : IHasGitHubClient
        {
            return context =>
            {
                return Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    context.GitHubClient,
                    repositorySpecification);
            };
        }

        /// <inheritdoc cref="IGitHubOperator.Create_Repository_NonIdempotent(Octokit.GitHubClient, RepositorySpecification)"/>
        public Func<TContext, Task> Create_Repository_NonIdempotent_I02<TContext>(
            RepositorySpecification repositorySpecification)
            where TContext : IHasGitHubClient, IWithRepository
        {
            return async context =>
            {
                context.Repository = await Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    context.GitHubClient,
                    repositorySpecification);
            };
        }

        /// <inheritdoc cref="L0078.F001.IGitHubClientOperator.Delete_Repository_NonIdempotent(Octokit.GitHubClient, string, string)"/>
        public async Task Delete_Repository_NonIdempotent<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            await Instances.GitHubClientOperator.Delete_Repository_NonIdempotent(
                context.GitHubClient,
                context.RepositoryOwnerName,
                context.RepositoryName);
        }

        /// <inheritdoc cref="L0078.F001.IGitHubClientOperator.Delete_Repository_Idempotent(Octokit.GitHubClient, string, string)"/>
        public Func<TRepositoryContext, Task> Delete_Repository_Idempotent<TRepositoryContext, TGitHubContext>(
            TGitHubContext gitHubContext,
            Func<TRepositoryContext, bool, Task> outputHandler = default)
            where TGitHubContext :
            IHasGitHubClient
            where TRepositoryContext : 
            IHasRepositoryOwnerName,
            IHasRepositoryName
        {
            return async context =>
            {
                var wasDeleted = await Instances.GitHubClientOperator.Delete_Repository_Idempotent(
                    gitHubContext.GitHubClient,
                    context.RepositoryOwnerName,
                    context.RepositoryName);

                await Instances.FunctionOperator.Run(
                    context,
                    wasDeleted,
                    outputHandler);
            };
        }

        /// <inheritdoc cref="L0078.F001.IGitHubClientOperator.Delete_Repository_Idempotent(Octokit.GitHubClient, string, string)"/>
        public Func<TRepositoryContext, TGitHubContext, Task> Delete_Repository_Idempotent<TRepositoryContext, TGitHubContext>(
            Func<TRepositoryContext, bool, Task> outputHandler = default)
            where TGitHubContext :
            IHasGitHubClient
            where TRepositoryContext :
            IHasRepositoryOwnerName,
            IHasRepositoryName
        {
            return async (repositoryContext, gitHubContext) =>
            {
                var wasDeleted = await Instances.GitHubClientOperator.Delete_Repository_Idempotent(
                    gitHubContext.GitHubClient,
                    repositoryContext.RepositoryOwnerName,
                    repositoryContext.RepositoryName);

                await Instances.FunctionOperator.Run(
                    repositoryContext,
                    wasDeleted,
                    outputHandler);
            };
        }

        /// <inheritdoc cref="L0078.F001.IGitHubClientOperator.Delete_Repository_Idempotent(Octokit.GitHubClient, string, string)"/>
        public async Task Delete_Repository_Idempotent<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            await Instances.GitHubClientOperator.Delete_Repository_Idempotent(
                context.GitHubClient,
                context.RepositoryOwnerName,
                context.RepositoryName);
        }

        /// <inheritdoc cref="L0078.F001.IGitHubClientOperator.Delete_Repository_Idempotent(Octokit.GitHubClient, string, string)"/>
        public Func<TContext, Task> Delete_Repository_Idempotent<TContext>(
            Func<TContext, bool, Task> outputHandler = default)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            return async context =>
            {
                var wasDeleted = await Instances.GitHubClientOperator.Delete_Repository_Idempotent(
                    context.GitHubClient,
                    context.RepositoryOwnerName,
                    context.RepositoryName);

                await Instances.FunctionOperator.Run(
                    context,
                    wasDeleted,
                    outputHandler);
            };
        }

        public Func<TContext, Task> Exists_Repository<TContext>(
            Func<TContext, bool, Task> outputHandler = default)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            return context => Instances.ContextOperator.In_Context(
                context,
                this.Exists_Repository(
                    context.RepositoryOwnerName,
                    context.RepositoryName,
                    outputHandler));
        }

        public Task Verify_Repository_Exists<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            return Instances.ContextOperator.In_Context(
                context,
                this.Exists_Repository<TContext>(
                    (context, repositoryExists) =>
                    {
                        if(!repositoryExists)
                        {
                            var message = $"{context.RepositoryOwnerName}/{context.RepositoryName}: GitHub repository does not exist.";

                            throw new Exception(message);
                        }

                        return Task.CompletedTask;
                    }
                )
            );
        }

        public Task Verify_Repository_DoesNotExist<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositoryOwnerName, IHasRepositoryName
        {
            return Instances.ContextOperator.In_Context(
                context,
                this.Exists_Repository<TContext>(
                    (context, repositoryExists) =>
                    {
                        if (repositoryExists)
                        {
                            var message = $"{context.RepositoryOwnerName}/{context.RepositoryName}: GitHub repository exists.";

                            throw new Exception(message);
                        }

                        return Task.CompletedTask;
                    }
                )
            );
        }
    }
}
