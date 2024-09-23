using System;

using R5T.T0132;


namespace R5T.F0044
{
	[FunctionalityMarker]
	public partial interface INameOperator : IFunctionalityMarker
	{
		public string AdjustNameForPrivacy(string name, bool isPrivate)
		{
			var output = isPrivate
				? this.AppendToken(
					name,
					Instances.NameTokens.Private)
				: name
				;

			return output;
		}

		public string AppendToken(string name, string token)
        {
			var tokenSeparator = this.GetTokenSeparator();

			var output = $"{name}{tokenSeparator}{token}";
			return output;
        }

		public char GetTokenSeparator()
        {
			var nameTokenSeparator = Instances.Characters.Period;
			return nameTokenSeparator;
        }

		/// <summary>
		/// Determines whether the given name indicates the named object is private.
		/// </summary>
		/// <remarks>
		/// This is determined by whether the given name ends with the <see cref="INameTokens.Private"/> ("<inheritdoc cref="INameTokens.Private" path="descendant::value"/>") name token.
		/// </remarks>
		public bool Is_AdjustedForPrivacy(string name)
		{
            var endsWithPrivacyToken = Instances.StringOperator.EndsWith(
                name,
                Instances.NameTokens.Private);

			var output = endsWithPrivacyToken;
			return output;
        }

		/// <summary>
		/// Determines if the given name matches the given privacy value.
		/// </summary>
		public bool Is_AdjustedForPrivacy(
			string name,
			bool is_Private)
		{
			var is_AdjustedForPrivacy = this.Is_AdjustedForPrivacy(name);

			var output = is_Private
				// If the name should be private, whether it has been correctly adjusted for privacy is just whether it has been adjusted for privacy.
				? is_AdjustedForPrivacy
				// If the name should *not* be private, whether it has been correctly adjusted for privacy is just whether it has *not* been adjusted for privacy.
				: !is_AdjustedForPrivacy
				;

			return output;
		}

		public void Verify_AdjustedForPrivacy(
			string name,
			bool is_Private)
		{
			var is_AdjustedForPrivacy = this.Is_AdjustedForPrivacy(
				name,
				is_Private);

			if(!is_AdjustedForPrivacy)
			{
				throw new Exception($"The name '{name}' does not match the expected privacy value '{is_Private}'.");
			}
		}

  //      /// <summary>
  //      /// Given a name and an expected privacy setting, if the name has not been correctly adjusted for privacy, do so.
  //      /// <para>
  //      /// Note: this means that the name will be changed!
  //      /// Either the the <see cref="INameTokens.Private"/> ("<inheritdoc cref="INameTokens.Private" path="descendant::value"/>") name token will be added, if needed,
		///// or removed, if needed.
  //      /// </para>
  //      /// </summary>
  //      public string Ensure_IsAdjustedForPrivacy(
		//	string name,
		//	bool is_Private)
		//{

		//}
	}
}