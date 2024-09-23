using System;

using R5T.T0132;


namespace R5T.F0044
{
	[FunctionalityMarker]
	public partial interface IRepositoryNameOperator : IFunctionalityMarker
	{
		/// <inheritdoc cref="INameOperator.AdjustNameForPrivacy(string, bool)"/>
		public string AdjustName_ForPrivacy(
			string repositoryName,
			bool is_Private)
			=> Instances.NameOperator.AdjustNameForPrivacy(
				repositoryName,
				is_Private);

        /// <inheritdoc cref="INameOperator.Verify_AdjustedForPrivacy(string, bool)"/>
        public void Verify_AdjustedForPrivacy(
			string repositoryName,
			bool is_Private)
			=> Instances.NameOperator.Verify_AdjustedForPrivacy(
				repositoryName,
				is_Private);
    }
}