using System;


namespace R5T.L0081.O002
{
    public class RepositoryContextOperations : IRepositoryContextOperations
    {
        #region Infrastructure

        public static IRepositoryContextOperations Instance { get; } = new RepositoryContextOperations();


        private RepositoryContextOperations()
        {
        }

        #endregion
    }
}
