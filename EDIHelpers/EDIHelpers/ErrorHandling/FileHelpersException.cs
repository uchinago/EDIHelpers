#region "  © Copyright 2005-07 to Marcos Meli - http://www.marcosmeli.com.ar" 

// Errors, suggestions, contributions, send a mail to: marcos@EDIHelpers.com.

#endregion

using System;

namespace EDIHelpers.ErrorHandling
{
	/// <summary>Base class for all the library Exceptions.</summary>
	public class EDIHelpersException : Exception
	{
		/// <summary>Basic constructor of the exception.</summary>
		/// <param name="message">Message of the exception.</param>
		public EDIHelpersException(string message) : base(message)
		{
		}

		/// <summary>Basic constructor of the exception.</summary>
		/// <param name="message">Message of the exception.</param>
		/// <param name="innerEx">The inner Exception.</param>
		public EDIHelpersException(string message, Exception innerEx) : base(message, innerEx)
		{
			
		}

	}
}