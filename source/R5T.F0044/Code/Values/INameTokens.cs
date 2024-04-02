using System;

using R5T.T0131;


namespace R5T.F0044
{
	[ValuesMarker]
	public partial interface INameTokens : IDraftValuesMarker
	{
        /// <summary>
        /// <para><value>Client</value></para>
        /// </summary>
        public string Client => "Client";

        /// <summary>
        /// <para><value>Construction</value></para>
        /// </summary>
        public string Construction => "Construction";

        /// <summary>
        /// <para><value>Library</value></para>
        /// </summary>
        public string Library => "Library";

        /// <summary>
        /// <para><value>Private</value></para>
        /// </summary>
		public string Private => "Private";

        /// <summary>
        /// <para><value>Server</value></para>
        /// </summary>
        public string Server => "Server";
    }
}