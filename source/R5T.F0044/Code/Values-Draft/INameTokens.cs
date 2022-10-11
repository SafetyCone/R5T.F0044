using System;

using R5T.T0131;


namespace R5T.F0044
{
	[DraftValuesMarker]
	public partial interface INameTokens : IDraftValuesMarker
	{
		public string Construction => "Construction";
		public string Private => "Private";
	}
}