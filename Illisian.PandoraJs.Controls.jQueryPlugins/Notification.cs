// Class1.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using jQueryApi;
using Illisian.PandoraJs.Utils.Extension;
using System.Collections;
using Illisian.PandoraJs.Utils;

using Illisian.PandoraJs.Utils.Extension.jQueryPlugins;
namespace Illisian.PandoraJs.Controls.jQueryPlugin
{


	public class Notification : Control
	{

		private string _closerTemplate = "<div>[ close all ]</div>";
		private bool _closer = true;
		private string _glue = "before";

		public string CloserTemplate
		{
			get
			{
				return _closerTemplate;
			}
			set
			{
				if (!IsInitialised)
				{
					_closerTemplate = value;
				}
				else
				{
					Logging.Log(LoggingType.Warning, "You cannot change the CloserTemplate after the control has been initialised", null);
				}
			}
		}

		public bool Closer
		{
			get
			{
				return _closer;
			}
			set
			{
				if (!IsInitialised)
				{
					_closer = value;
				}
				else
				{

					Logging.Log(LoggingType.Warning, "You cannot change the Closer Option after the control has been initialised", null);
				}
			}
		}

		public string Glue
		{
			get
			{
				return _glue;
			}
			set
			{
				if (!IsInitialised)
				{
					_glue = value;
				}
				else
				{
					Logging.Log(LoggingType.Warning, "You cannot change the Glue Option after the control has been initialised", null);
				}
			}
		}



		public Notification()
		{
			this.Id = "notification";
		}

		protected override void Control_Render()
		{

		}

		public override string[] CssFiles
		{
			get
			{
				return new string[] {
					"jquery.jgrowl"
				};
			}
		}
		public override string[] JavascriptFiles
		{
			get
			{
				return new string[] { "jquery.jgrowl" };
			}
		}

		protected override void Control_PreRender()
		{
			//TODO: Couldnt figure out how to replicate this in the Extensions class
			Script.Literal("$.jGrowl.defaults.closer = {0}", _closer);
			Script.Literal("$.jGrowl.defaults.closerTemplate = {0}", _closerTemplate);
			Script.Literal("$.jGrowl.defaults.glue = {0}", _glue);
			base.Control_PreRender();
		}

		public void CreateNotification(string message, Dictionary options)
		{
			if (!IsInitialised)
			{
				Window.SetTimeout(delegate { CreateNotification(message, options); }, 50);
			}
			else
			{
				if (options != null)
				{
					jGrowlExtension.jGrowl(message, options);
				}
				else
				{
					jGrowlExtension.jGrowl(message);
				}
			}
		}
	}
}
