using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;

namespace Appium.Samples.Helpers
{
	public class Caps
	{

		public static DesiredCapabilities getAndroid19Caps (string app) {
			DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.AppiumVersion, "1.0");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "4.4.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
			return capabilities;
		}
	}
}

