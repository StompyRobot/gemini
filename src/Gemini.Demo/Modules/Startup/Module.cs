﻿using System.ComponentModel.Composition;
using System.Reflection;
using Caliburn.Micro;
using Gemini.Framework;
using Gemini.Framework.Services;
using Gemini.Modules.Output;

namespace Gemini.Demo.Modules.Startup
{
	[Export(typeof(IModule))]
	public class Module : ModuleBase
	{
		[Import]
		private IOutput _output;

		[Import]
		private IResourceManager _resourceManager;

		public override void Initialize()
		{
			Shell.Title = "Gemini Demo";
			Shell.StatusBar.Message = "Hello world!";
			Shell.Icon = _resourceManager.GetBitmap("Resources/Icon.png", 
				Assembly.GetExecutingAssembly().GetAssemblyName());

			_output.AppendLine("Started up");
		}
	}
}