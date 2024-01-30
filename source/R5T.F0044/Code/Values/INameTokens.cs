using System;

using R5T.T0131;


namespace R5T.F0044
{
	[ValuesMarker]
	public partial interface INameTokens : IDraftValuesMarker
	{
        public string Client => "Client";
        public string Construction => "Construction";
        public string Library => "Library";
		public string Private => "Private";
        public string Server => "Server";
    }
}