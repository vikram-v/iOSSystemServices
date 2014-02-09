using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class BatteryInfoViewController : DialogViewController
	{
		public BatteryInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Battery Info") {
				new Section () {
					new StringElement ("Battery Level", Convert.ToString (SystemServices.Instance.BatteryLevel)),
					new StringElement ("Is Charging", Convert.ToString (SystemServices.Instance.Charging)),
					new StringElement ("Fully Charged", Convert.ToString (SystemServices.Instance.FullyCharged))		
				}
			};
		}
	}
}
