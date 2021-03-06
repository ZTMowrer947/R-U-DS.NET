﻿using Mowrer.DeadSimple.Core.Models;
using System;
using System.Collections.Generic;

namespace Mowrer.DeadSimple.Core
{
	/// <summary>
	/// Responsible for parsing the instructions and performing the respective operations.
	/// </summary>
    public static class Parser
    {
		/// <summary>
		/// Parses the list of instruction from the lexer and performs the respective operations.
		/// </summary>
		/// <param name="operations">The operations to perform.</param>
		public static void ParseFile(List<OperatorChar> operations)
		{
			// All the instructions operate on this variable
			int stack = 0;

			// Go through each instruction
			foreach (var op in operations)
			{
				// Classify the instruction and perform the respective operation
				switch (op)
				{
					case OperatorChar.Underscore: // Reset
						stack = 0;
						break;

					case OperatorChar.Plus:
						stack++;
						break;

					case OperatorChar.Minus:
						stack--;
						break;

					case OperatorChar.S: // Print out 
						Console.Write((char)stack);
						break;
				}
			}
		}
    }
}
