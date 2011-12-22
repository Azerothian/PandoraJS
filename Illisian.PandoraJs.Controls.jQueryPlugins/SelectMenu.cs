// SelectMenu.cs
//

using System;
using System.Collections.Generic;

using Illisian.PandoraJs.Utils.Extension;
using Illisian.PandoraJs.Utils.Extension.jQueryPlugins;
using jQueryApi;
namespace Illisian.PandoraJs.Controls.jQueryPlugin
{
	public class SelectMenu : Select
	{
		public override string[] JavascriptFiles
		{
			get
			{
				return new string[] { "jquery.ui.selectmenu" };
			}
		}
		public override string[] CssFiles
		{
			get
			{
				return new string[] { "jquery.ui.selectmenu" };
			}
		}
		
		protected override void Control_SetProperties()
		{
			if (IsRendered)
			{
				base.Control_SetProperties();
				jQueryExtension.Select<jQueryPluginObject>("#" + ControlId).selectmenu();
			}
		}

		public string SelectedValue
		{
			get
			{
				if (IsRendered)
				{
					return jQuery.Select("#" + ControlId).GetValue();
				}
				return "";
			}
		}

	}
}
