using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bejinariu_Paul_Catalin_Lab7;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
