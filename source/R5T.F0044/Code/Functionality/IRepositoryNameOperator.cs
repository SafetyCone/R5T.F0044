using System;

using R5T.T0132;


namespace R5T.F0044
{
	[FunctionalityMarker]
	public partial interface IRepositoryNameOperator : IFunctionalityMarker
	{
		public string AdjustName_ForPrivacy(
			string repositoryName,
			bool isPrivate)
		{
			var output = NameOperator.Instance.AdjustNameForPrivacy(repositoryName, isPrivate);
			return output;
		}
	}
}