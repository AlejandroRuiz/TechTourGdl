using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
//using Plugin.Media;
using UIKit;

namespace TechTourGdl.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			//CrossMedia.Current.Initialize();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
