using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace EventHorizon.Maui.BabylonJS
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}