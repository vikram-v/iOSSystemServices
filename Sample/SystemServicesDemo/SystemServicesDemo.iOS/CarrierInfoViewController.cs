using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class CarrierInfoViewController : DialogViewController
	{
		public CarrierInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Carrier Info") {
				new Section () {
					new StringElement ("Carrier Name", SystemServices.Instance.CarrierName),
					new StringElement ("Carrier Country", SystemServices.Instance.CarrierCountry),
					new StringElement ("Carrier Mobile Country Code", SystemServices.Instance.CarrierMobileCountryCode),
					new StringElement ("Carrier ISO Country Code", SystemServices.Instance.CarrierISOCountryCode),
					new StringElement ("Carrier Mobile Network Code", SystemServices.Instance.CarrierMobileNetworkCode),
					new StringElement ("Carrier Allows VOIP", Convert.ToString (SystemServices.Instance.CarrierAllowsVOIP))
				}
			};
		}
	}
}
