using System;


namespace R5T.L0081.O002
{
    public static class Instances
    {
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static L0066.IFunctionOperator FunctionOperator => L0066.FunctionOperator.Instance;
        public static L0078.F001.IGitHubClientOperator GitHubClientOperator => L0078.F001.GitHubClientOperator.Instance;
        public static L0079.IGitHubOperator GitHubOperator => L0079.GitHubOperator.Instance;
    }
}