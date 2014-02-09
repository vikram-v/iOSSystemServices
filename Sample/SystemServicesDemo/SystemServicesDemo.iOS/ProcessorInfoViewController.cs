using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SystemServicesBinding;

namespace SystemServicesDemo.iOS
{
	public partial class ProcessorInfoViewController : DialogViewController
	{
		public ProcessorInfoViewController () : base (UITableViewStyle.Grouped, null, true)
		{
			Root = new RootElement ("Processor Info") {
				new Section () {
					new StringElement ("Number Of Processors", Convert.ToString (SystemServices.Instance.NumberOfProcessors)),
					new StringElement ("Number of Active Processors", Convert.ToString (SystemServices.Instance.NumberOfActiveProcessors)),
					new StringElement ("Processor Speed", Convert.ToString (SystemServices.Instance.ProcessorSpeed)),
					new StringElement ("Processor Bus Speed", Convert.ToString (SystemServices.Instance.ProcessorBusSpeed))
				}
			};
		}
	}
}
