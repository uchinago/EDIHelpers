using System;
using System.CodeDom.Compiler;
using EDIHelpers.ErrorHandling;

#region "  © Copyright 2005-07 to Marcos Meli - http://www.marcosmeli.com.ar" 

// Errors, suggestions, contributions, send a mail to: marcos@EDIHelpers.com.

#endregion

namespace EDIHelpers.RunTime
{
	/// <summary>
	/// Exception with error information of the run time compilation.
	/// </summary>
	public sealed class RunTimeCompilationException : EDIHelpersException
	{

		internal RunTimeCompilationException(string message, string sourceCode, CompilerErrorCollection errors) : base(message)
		{
			mSourceCode = sourceCode;
			mCompilerErrors = errors;
		}

		private string mSourceCode;

		/// <summary>
		/// The source code that generates the Exception
		/// </summary>
		public string SourceCode
		{
			get { return mSourceCode; }
		}

		private CompilerErrorCollection mCompilerErrors;

		/// <summary>
		/// The errors returned from the compiler.
		/// </summary>
		public CompilerErrorCollection CompilerErrors
		{
			get { return mCompilerErrors; }
		}


	}
}