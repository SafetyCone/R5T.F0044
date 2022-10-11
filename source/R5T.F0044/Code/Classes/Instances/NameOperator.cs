using System;


namespace R5T.F0044
{
	public class NameOperator : INameOperator
	{
		#region Infrastructure

	    public static INameOperator Instance { get; } = new NameOperator();

	    private NameOperator()
	    {
        }

	    #endregion
	}
}