using System;


namespace R5T.F0044
{
	public class NameTokens : INameTokens
	{
		#region Infrastructure

	    public static INameTokens Instance { get; } = new NameTokens();

	    private NameTokens()
	    {
        }

	    #endregion
	}
}