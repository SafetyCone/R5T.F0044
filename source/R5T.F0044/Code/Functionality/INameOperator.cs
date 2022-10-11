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
			var nameTokenSeparator = Z0000.Characters.Instance.Period;
			return nameTokenSeparator;
        }
	}
}