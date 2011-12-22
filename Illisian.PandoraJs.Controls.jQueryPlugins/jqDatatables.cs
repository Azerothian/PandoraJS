// Wysiwyg.cs
//

using System;
using System.Collections.Generic;

using System.Collections;
using jQueryApi;
using Illisian.PandoraJs.Utils.Extension;
using Illisian.PandoraJs.Utils.Extension.jQueryPlugins;

namespace Illisian.PandoraJs.Controls.jQueryPlugin
{
	public class jqDatatables : Panel
	{
		private DataTable _table;
		private bool _enablejQueryTheme = false;
		public bool EnablejQueryTheme
		{
			get
			{
				return _enablejQueryTheme;
			}
			set
			{
				_enablejQueryTheme = value;
			}
		}
		//private bool _isDataTablesRendered = false;
		public DataTableObject DataTableObject = null; //TODO: change this to a property

		public jqDatatables()
		{
			_table = new DataTable();
			_table.Id = "table";
			_table.Width = "100%";
			_table.Height = "100%";
			this.AddChild(_table);
		}
		public DataTable DataTable
		{
			get
			{
				return _table;
			}
		}
		protected override void Control_Load()
		{
			this.DataTableObject = jQueryExtension.Select<jQueryPluginObject>("#" + _table.ControlId).dataTable(
				new Dictionary( "bJQueryUI", _enablejQueryTheme)
				
				
				);
			//_isDataTablesRendered = true;
			Control_SetProperties();
			base.Control_Load();
		}

		//public override void SetStyle(string styleName, string styleAttr)
		//{
		//    if (_isDataTablesRendered)
		//    {
		//        jQuery.Select("#" + ControlId).Parent().CSS(styleName, styleAttr);
		//    }
		//}
		//public override string GetStyle(string styleName)
		//{
		//    if (_isDataTablesRendered)
		//    {
		//        return jQuery.Select("#" + ControlId).Parent().GetCSS(styleName);
		//    }
		//    return "";
		//}
		public override string[] CssFiles
		{
			get
			{
				return new string[] { "datatables.ui" };
			}
		}
		public override string[] JavascriptFiles
		{
			get
			{
				return new string[] { "jquery.dataTables" };
			}
		}
	}

}
