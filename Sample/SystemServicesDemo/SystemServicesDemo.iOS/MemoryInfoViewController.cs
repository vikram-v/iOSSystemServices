using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class MemoryInfoViewController : DialogViewController
	{
		public MemoryInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Memory Info") {
				new Section () {
					new StringElement ("Total Memory", Convert.ToString (SystemServices.Instance.TotalMemory)),
				},
				new Section ("Free Memory") {
					new StringElement ("Free Memory", Convert.ToString (SystemServices.Instance.FreeMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.FreeMemoryInPercent)),
				},
				new Section ("Used Memory") {
					new StringElement ("Raw", Convert.ToString (SystemServices.Instance.UsedMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.UsedMemoryInPercent)),
				},
				new Section ("Active Memory") {
					new StringElement ("Raw", Convert.ToString (SystemServices.Instance.ActiveMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.ActiveMemoryInPercent)),
				},
				new Section ("InActive Memory") {
					new StringElement ("Raw", Convert.ToString (SystemServices.Instance.InactiveMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.InactiveMemoryInPercent)),
				},
				new Section ("Wired Memory") {
					new StringElement ("Raw", Convert.ToString (SystemServices.Instance.WiredMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.WiredMemoryInPercent)),

				},
				new Section ("Purgable Memory") {
					new StringElement ("Raw", Convert.ToString (SystemServices.Instance.PurgableMemoryInRaw)),
					new StringElement ("Percent", Convert.ToString (SystemServices.Instance.PurgableMemoryInPercent)),
				}
			};
		}
	}
}
