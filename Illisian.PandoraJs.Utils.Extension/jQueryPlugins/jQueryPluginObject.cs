// jQueryPluginObject.cs
//

using System;
using System.Collections.Generic;
using System.Collections;

namespace Illisian.PandoraJs.Utils.Extension.jQueryPlugins
{
	public partial class jQueryPluginObject : jQueryExtObject
	{
		public jQueryPluginObject Bind(string eventName, PandoraEventHandler eventHandler)
		{
			return this;
		}
		/// <summary>
		/// Attaches a handler for handling the specified event on the matched set of elements.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <param name="eventData">The event data.</param>
		/// <param name="eventHandler">The event handler.</param>
		/// <returns></returns>
		public jQueryPluginObject Bind(string eventName, Dictionary eventData, PandoraEventHandler eventHandler)
		{
			return this;
		}

	}
}
