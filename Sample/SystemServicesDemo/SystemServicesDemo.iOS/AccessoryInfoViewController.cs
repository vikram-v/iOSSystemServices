using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class AccessoryInfoViewController : DialogViewController
	{
		public AccessoryInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Accessories Info") {
				new Section () {
					new StringElement ("Accessories Attached", Convert.ToString (SystemServices.Instance.AccessoriesAttached)),
					new StringElement ("Headphones Attached", Convert.ToString (SystemServices.Instance.HeadphonesAttached)),
					new StringElement ("Number of Attached Accessories", Convert.ToString (SystemServices.Instance.NumberAttachedAccessories)),
					new MultilineElement ("Attached Accessories", SystemServices.Instance.NameAttachedAccessories),
				}
			};
			Root.UnevenRows = true;
		}
	}
}
