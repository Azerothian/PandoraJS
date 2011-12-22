// Wysiwyg.cs
//

using System;
using System.Collections.Generic;

using Illisian.PandoraJs.Utils.Extension.jQueryPlugins;
using System.Collections;
using jQueryApi;
using Illisian.PandoraJs.Utils.Extension;

namespace Illisian.PandoraJs.Controls.jQueryPlugin
{
	public class Wysiwyg : Control
	{



		private bool _bold = true;
		private bool _italic = true;
		private bool _underline = true;
		private bool _strikeThrough = true;
		private bool _justifyLeft = true;
		private bool _justifyCenter = true;
		private bool _justifyRight = true;
		private bool _justifyFull = true;
		private bool _indent = true;
		private bool _outdent = true;
		private bool _subscript = true;
		private bool _superscript = true;
		private bool _undo = true;
		private bool _redo = true;
		private bool _insertOrderedList = true;
		private bool _insertUnorderedList = true;
		private bool _insertHorizontalRule = true;
		private bool _cut = true;
		private bool _copy = true;
		private bool _paste = true;
		private bool _html = false;
		private bool _increaseFontSize = true;
		private bool _decreaseFontSize = true;


		protected override void Control_SetProperties()
		{
			base.Control_SetProperties();

			jQueryExtension.Select<jQueryPluginObject>("#" + ControlId + "-text").Wysiwyg(new Dictionary(
				"controls", new Dictionary(
					"bold", new Dictionary("visible", _bold),
					"italic", new Dictionary("visible", _italic),
					"underline", new Dictionary("visible", _underline),
					"strikeThrough", new Dictionary("visible", _strikeThrough),
					"justifyLeft", new Dictionary("visible", _justifyLeft),
					"justifyCenter", new Dictionary("visible", _justifyCenter),
					"justifyRight", new Dictionary("visible", _justifyRight),
					"justifyFull", new Dictionary("visible", _justifyFull),
					"indent", new Dictionary("visible", _indent),
					"outdent", new Dictionary("visible", _outdent),
					"subscript", new Dictionary("visible", _subscript),
					"superscript", new Dictionary("visible", _superscript),
					"undo", new Dictionary("visible", _undo),
					"redo", new Dictionary("visible", _redo),
					"insertOrderedList", new Dictionary("visible", _insertOrderedList),
					"insertUnorderedList", new Dictionary("visible", _insertUnorderedList),
					"insertHorizontalRule", new Dictionary("visible", _insertHorizontalRule),
					"cut", new Dictionary("visible", _cut),
					"copy", new Dictionary("visible", _copy),
					"paste", new Dictionary("visible", _paste),
					"html", new Dictionary("visible", _html),
					"increaseFontSize", new Dictionary("visible", _increaseFontSize),
					"decreaseFontSize", new Dictionary("visible", _decreaseFontSize)
					),
					"events", new Dictionary(
						"click", null
					),
					"dialog", "jqueryui"
				));


		}

		private string _content = "";
		public string Content
		{
			get
			{
				if (IsRendered)
				{
					return (string)jQueryExtension.Select<jQueryPluginObject>("#" + ControlId + "-text").Wysiwyg("getContent");
				}
				else
				{
					return _content;
				}
			}
			set
			{
				if(IsRendered)
					jQueryExtension.Select<jQueryPluginObject>("#" + ControlId + "-text").Wysiwyg("setContent", value);
				_content = value;

			}


		}
		public override string[] CssFiles
		{
			get
			{
				return new string[] { "jquery.wysiwyg" };
			}
		}
		public override string[] JavascriptFiles
		{
			get
			{
				return new string[] { "jquery.wysiwyg" };
			}
		}

		protected override void Control_Render()
		{
			jQuery.Select("#" + Parent.ControlId).Append("<div id='" + ControlId + "'></div>");
			jQuery.Select("#" + ControlId).Append("<textarea style='width:100%;height:100%;' id='" + ControlId + "-text'>" + _content + "</textarea>");
		}
	}

}
