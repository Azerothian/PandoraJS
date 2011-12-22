// Support.cs
//

using System;
using System.Collections.Generic;
using Illisian.PandoraJs.Utils.Extension;

namespace Illisian.PandoraJs.Utils
{
	public class Support
	{
		public static void DebuggerUtil()
		{
			Script.Literal("debugger;");
		}


		public static bool IsConsoleSupported()
		{
			return (bool)Script.Literal("console != undefined;");
		}
		public static bool ElementSupports(string element, string type)
		{
			return (bool)Script.Literal("({0} in document.createElement({1}))", type, element);
		}
		public static bool ConsoleSupports(string type)
		{
			if (IsConsoleSupported())
			{
				return (bool)Script.Literal("({0} in console)", type);
			}
			return false;
		}


		public static bool IsTextBoxPlaceholderSupported { get { return ElementSupports("input", "placeholder"); } }
		public static bool IsConsoleWarnSupported { get { return ConsoleSupports("warn"); } }
		public static bool IsConsoleInfoSupported { get { return ConsoleSupports("info"); } }
		public static bool IsConsoleDebugSupported { get { return ConsoleSupports("debug"); } }
		public static bool IsConsoleErrorSupported { get { return ConsoleSupports("error"); } }
		public static bool IsConsoleLogSupported { get { return ConsoleSupports("log"); } }
	}
}
