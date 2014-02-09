using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class NetworkInfoViewController : DialogViewController
	{
		public NetworkInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Network Info") {
				new Section () {
					new StringElement ("Current IP Address", SystemServices.Instance.CurrentIPAddress),
					new StringElement ("Current MACAddress", SystemServices.Instance.CurrentMACAddress),
					new StringElement ("External IP Address", SystemServices.Instance.ExternalIPAddress)	
				}
				, 
				new Section ("Cell") {
					new StringElement ("Is Connected ", Convert.ToString (SystemServices.Instance.ConnectedToCellNetwork)),
					new StringElement ("IP Address", SystemServices.Instance.CellIPAddress),
					new StringElement ("MAC Address", SystemServices.Instance.CellMACAddress),
					new StringElement ("Netmask Address", SystemServices.Instance.CellNetmaskAddress),
					new StringElement ("Broadcast Address", SystemServices.Instance.CellBroadcastAddress)
				},
				new Section ("WIFI") {
					new StringElement ("Is Connected", Convert.ToString (SystemServices.Instance.ConnectedToWiFi)),
					new StringElement ("IP Address", SystemServices.Instance.WiFiIPAddress),
					new StringElement ("MAC Address", SystemServices.Instance.WiFiMACAddress),
					new StringElement ("Netmask Address", SystemServices.Instance.WiFiNetmaskAddress),
					new StringElement ("Broadcast Address", SystemServices.Instance.WiFiBroadcastAddress)
				}
			};	
		
		}
	}
}
