

#region "  © Copyright 2005-07 to Marcos Meli - http://www.marcosmeli.com.ar" 

// Errors, suggestions, contributions, send a mail to: marcos@EDIHelpers.com.

#endregion

namespace EDIHelpers.Enums
{
	/// <summary>Indicates the behavior when the <see cref="FileHelperEngine"/> class found an error.</summary>
	public enum ErrorMode
	{
		/// <summary>Default value, this simple Rethrow the original exception.</summary>
		ThrowException = 0,
		/// <summary>Add an <see cref="ErrorInfo"/> to the array of <see cref="ErrorManager.Errors"/>.</summary>
		SaveAndContinue,
		/// <summary>Simply ignores the exception an continue.</summary>
		IgnoreAndContinue
	}
}