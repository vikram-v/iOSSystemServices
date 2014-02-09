using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class UniqueIdentifiersInfoViewController : DialogViewController
	{
		public UniqueIdentifiersInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Unique Identifiers") {
				new Section ("Unique ID") {
					new MultilineElement (SystemServices.Instance.UniqueID),
				},
				new Section ("Device Signature") {

					new MultilineElement (SystemServices.Instance.DeviceSignature),
				},
				new Section ("CFUUID") {
					new MultilineElement (SystemServices.Instance.Cfuuid),
				}
			};
			Root.UnevenRows = true;
		}
	}
}
