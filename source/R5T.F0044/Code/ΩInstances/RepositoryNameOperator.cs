using System;


namespace R5T.F0044
{
	public class RepositoryNameOperator : IRepositoryNameOperator
	{
		#region Infrastructure

	    public static IRepositoryNameOperator Instance { get; } = new RepositoryNameOperator();

	    private RepositoryNameOperator()
	    {
        }

	    #endregion
	}
}