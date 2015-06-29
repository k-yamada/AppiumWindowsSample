using System;
using System.Collections.Generic;

namespace Appium.Samples.Helpers
{
	public class Apps
	{
		static Dictionary<string, string> DEV = new Dictionary<string, string> {
			//{ "androidApiDemosLocal", "sample-code/apps/ApiDemos/bin/ApiDemos-debug.apk" }
            { "androidApiDemosLocal", "C:/Users/UFT/Documents/Visual Studio 2013/Projects/AppiumWindowsSample/UFTSample2/assets/ApiDemos-debug.apk" }
            
		};

		public static string get(string appKey) {
			return DEV[appKey];
		}
	}
}
