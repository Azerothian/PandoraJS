// jQueryUIEventItem.cs
//

using System;
using System.Collections.Generic;

using System.Collections;
using Illisian.PandoraJs.Utils.Extension;

namespace Illisian.PandoraJs.Events
{
	public class PandoraEventItem
	{
		public PandoraEventItem(object source, PandoraEventHandler evnt, Dictionary eventData)
		{
			Source = source;
			EventHandler = evnt;
			EventData = eventData;
		}
		public object Source = null;
		public Dictionary EventData = null;
		public PandoraEventHandler EventHandler = null;

		public void Invoke(IEnumerable<object> arr)
		{
			List<object> parm = new List<object>();
			parm.Add(EventData); if (arr != null)
			{
				foreach (object o in arr)
				{
					parm.Add(o);
				}
			}
			EventHandler.Invoke(Source, parm);

		}

	}
}
