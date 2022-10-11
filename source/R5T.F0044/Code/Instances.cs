using System;


namespace R5T.F0044
{
    public static class Instances
    {
        public static INameOperator NameOperator { get; } = F0044.NameOperator.Instance;
        public static INameTokens NameTokens { get; } = F0044.NameTokens.Instance;
    }
}