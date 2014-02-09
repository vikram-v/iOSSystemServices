using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class HomeViewController : DialogViewController
	{
		public HomeViewController () : base (UITableViewStyle.Grouped, null)
		{
			this.Title = "Home";
			Root = new RootElement ("System Services Info") {
				new Section () {
					new StyledStringElement ("Hardware", () => {
						NavigationController.PushViewController (new HardwareInfoViewController (), true);
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Is Jailbroken", Convert.ToString (SystemServices.Instance.JailBroken == 1)),

					new StyledStringElement ("Processor", () => {
						NavigationController.PushViewController (new ProcessorInfoViewController (), true); 
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Accessories", () => {
						NavigationController.PushViewController (new AccessoryInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Carrier", () => {
						NavigationController.PushViewController (new CarrierInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Battery", () => {
						NavigationController.PushViewController (new BatteryInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Network", () => {
						NavigationController.PushViewController (new NetworkInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Disk Info", () => {
						NavigationController.PushViewController (new DiskInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Memory Info", () => {
						NavigationController.PushViewController (new MemoryInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator },

					new StyledStringElement ("Universal Unique Identifiers", () => {
						NavigationController.PushViewController (new UniqueIdentifiersInfoViewController (), true);  
					}){ Accessory = UITableViewCellAccessory.DisclosureIndicator }
				}
			};
		}
	}
}
