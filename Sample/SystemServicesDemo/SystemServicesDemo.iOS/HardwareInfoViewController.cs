using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class HardwareInfoViewController : DialogViewController
	{
		public HardwareInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Hardware Information") {
				new Section () {
					new StringElement ("Device Name", SystemServices.Instance.DeviceName),
					new StringElement ("Device Model", SystemServices.Instance.DeviceModel),
					new StringElement ("System Name", SystemServices.Instance.SystemName),
					new StringElement ("System Version", SystemServices.Instance.SystemsVersion),
					new StringElement ("System's UpTime", SystemServices.Instance.SystemsUptime),
					new StringElement ("Device Type NotFormatted", SystemServices.Instance.SystemDeviceTypeNotFormatted),
					new StringElement ("Device Type Formatted", SystemServices.Instance.SystemDeviceTypeFormatted),
					new StringElement ("Screen Width", Convert.ToString (SystemServices.Instance.ScreenWidth)),
					new StringElement ("Screen Height", Convert.ToString (SystemServices.Instance.ScreenHeight)),
					new StringElement ("Screen Brightness", Convert.ToString (SystemServices.Instance.ScreenBrightness)),
					new StringElement ("Multitasking Enabled", Convert.ToString (SystemServices.Instance.MultitaskingEnabled)),
					new StringElement ("Proximity Sensor Enabled", Convert.ToString (SystemServices.Instance.ProximitySensorEnabled)),
					new StringElement ("Debugger Attached", Convert.ToString (SystemServices.Instance.DebuggerAttached)),
					new StringElement ("Is Plugged In", Convert.ToString (SystemServices.Instance.PluggedIn))
				},
				new Section ("Localization Info") {
					new StringElement ("Country", SystemServices.Instance.Country),
					new StringElement ("Language", SystemServices.Instance.Language),
					new StringElement ("TimeZoneSS", SystemServices.Instance.TimeZoneSS),
					new StringElement ("Currency", SystemServices.Instance.Currency)
				}
			};
		}
	}
}
