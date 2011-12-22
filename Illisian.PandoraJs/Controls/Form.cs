// Class1.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using jQueryApi;

using Illisian.PandoraJs.Utils.Extension;

namespace Illisian.PandoraJs.Controls
{


	public class Form : Control
	{
		protected override void Control_Render()
		{
			jQuery.Select("#" + Parent.ControlId).Append("<form id='" + ControlId + "'></form>");
		}
	}
}
