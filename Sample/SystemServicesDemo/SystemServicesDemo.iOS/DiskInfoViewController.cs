using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class DiskInfoViewController : DialogViewController
	{
		public DiskInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Disk Info") {
				new Section () {
					new StringElement ("Disk Space", SystemServices.Instance.DiskSpace),
					new StringElement ("Free DiskSpace InRaw", SystemServices.Instance.FreeDiskSpaceInRaw),
					new StringElement ("FreeDiskSpace", SystemServices.Instance.FreeDiskSpaceInPercent),
					new StringElement ("Used DiskSpace InRaw", SystemServices.Instance.UsedDiskSpaceInRaw),
					new StringElement ("Long DiskSpace", Convert.ToString (SystemServices.Instance.LongDiskSpace)),
					new StringElement ("Long FreeDiskSpace", Convert.ToString (SystemServices.Instance.LongFreeDiskSpace)),
				}
			};
		}
	}
}
