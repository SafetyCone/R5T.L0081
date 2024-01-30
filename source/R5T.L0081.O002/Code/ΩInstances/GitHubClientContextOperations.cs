using System;


namespace R5T.L0081.O002
{
    public class GitHubClientContextOperations : IGitHubClientContextOperations
    {
        #region Infrastructure

        public static IGitHubClientContextOperations Instance { get; } = new GitHubClientContextOperations();


        private GitHubClientContextOperations()
        {
        }

        #endregion
    }
}
