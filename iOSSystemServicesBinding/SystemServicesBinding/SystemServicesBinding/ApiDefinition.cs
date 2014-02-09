using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SystemServicesBinding
{
	[BaseType (typeof(NSObject))]
	public interface SystemServices
	{
		/* Hardware Information */

		#region Hardware Information

		/* All System Information in Dictionary Format */
		[Export ("allSystemInformation")]
		NSDictionary AllSystemInformation{ get; set; }

		[Export ("systemsUptime")]
		string SystemsUptime { get; set; }
		// Model of Device
		[Export ("deviceModel")]
		string DeviceModel { get; set; }
		// Device Name
		[Export ("deviceName")]
		string DeviceName { get; set; }
		// System Name
		[Export ("systemName")]
		string SystemName { get; set; }
		// System Version
		[Export ("systemsVersion")]
		string SystemsVersion { get; set; }
		// System Device Type (Not Formatted = iPhone1,0)
		[Export ("systemDeviceTypeNotFormatted")]
		string SystemDeviceTypeNotFormatted { get; set; }
		// System Device Type (Formatted = iPhone 1)
		[Export ("systemDeviceTypeFormatted")]
		string SystemDeviceTypeFormatted{ get; set; }
		// Get the Screen Width (X)
		[Export ("screenWidth")]
		int ScreenWidth{ get; set; }
		// Get the Screen Height (Y)
		[Export ("screenHeight")]
		int ScreenHeight{ get; set; }
		// Get the Screen Brightness
		[Export ("screenBrightness")]
		float ScreenBrightness{ get; set; }
		// Multitasking enabled?
		[Export ("multitaskingEnabled")]
		bool MultitaskingEnabled{ get; set; }
		// Proximity sensor enabled?
		[Export ("proximitySensorEnabled")]
		bool ProximitySensorEnabled{ get; set; }
		// Debugger Attached?
		[Export ("debuggerAttached")]
		bool DebuggerAttached{ get; set; }
		// Plugged In?
		[Export ("pluggedIn")]
		bool PluggedIn{ get; set; }

		#endregion

		#region Jailbreak Check

		// Jailbroken?
		[Export ("jailbroken")]
		int JailBroken{ get; set; }

		#endregion

		/* Processor Information */

		#region Processor Information

		// Number of processors
		[Export ("numberProcessors")]
		int NumberOfProcessors{ get; set; }
		// Number of Active Processors
		[Export ("numberActiveProcessors")]
		int NumberOfActiveProcessors{ get; set; }
		// Processor Speed in MHz
		[Export ("processorSpeed")]
		int ProcessorSpeed{ get; set; }
		// Processor Bus Speed in MHz
		[Export ("processorBusSpeed")]
		int ProcessorBusSpeed{ get; set; }

		#endregion

		#region Accessory Information

		// Are any accessories attached?
		[Export ("accessoriesAttached")]
		bool AccessoriesAttached{ get; set; }
		// Are headphone attached?
		[Export ("headphonesAttached")]
		bool HeadphonesAttached{ get; set; }
		// Number of attached accessories
		[Export ("numberAttachedAccessories")]
		int NumberAttachedAccessories{ get; set; }
		// Name of attached accessory/accessories (seperated by , comma's)
		[Export ("nameAttachedAccessories")]
		string  NameAttachedAccessories{ get; set; }

		#endregion

		/* Carrier Information */

		#region Carrier Information

		// Carrier Name
		[Export ("carrierName")]
		string CarrierName{ get; set; }
		// Carrier Country
		[Export ("carrierCountry")]
		string CarrierCountry{ get; set; }
		// Carrier Mobile Country Code
		[Export ("carrierMobileCountryCode")]
		string  CarrierMobileCountryCode{ get; set; }
		// Carrier ISO Country Code
		[Export ("carrierISOCountryCode")]
		string CarrierISOCountryCode{ get; set; }
		// Carrier Mobile Network Code
		[Export ("carrierMobileNetworkCode")]
		string CarrierMobileNetworkCode{ get; set; }
		// Carrier Allows VOIP
		[Export ("carrierAllowsVOIP")]
		bool  CarrierAllowsVOIP{ get; set; }

		#endregion

		/* Battery Information */

		#region Battery Information

		// Battery Level
		[Export ("batteryLevel")]
		float BatteryLevel{ get; set; }
		// Charging?
		[Export ("charging")]
		bool Charging{ get; set; }
		// Fully Charged?
		[Export ("fullyCharged")]
		bool FullyCharged{ get; set; }

		#endregion

		/* Network Information */

		#region Network Information

		// Get Current IP Address
		[Export ("currentIPAddress")]
		string CurrentIPAddress{ get; set; }
		// Get Current MAC Address
		[Export ("currentMACAddress")]
		string CurrentMACAddress{ get; set; }
		// Get External IP Address
		[Export ("externalIPAddress")]
		string ExternalIPAddress{ get; set; }
		// Get Cell IP Address
		[Export ("cellIPAddress")]
		string CellIPAddress{ get; set; }
		// Get Cell MAC Address
		[Export ("cellMACAddress")]
		string CellMACAddress{ get; set; }
		// Get Cell Netmask Address
		[Export ("cellNetmaskAddress")]
		string CellNetmaskAddress{ get; set; }
		// Get Cell Broadcast Address
		[Export ("cellBroadcastAddress")]
		string CellBroadcastAddress{ get; set; }
		// Get WiFi IP Address
		[Export ("wiFiIPAddress")]
		string WiFiIPAddress{ get; set; }
		// Get WiFi MAC Address
		[Export ("wiFiMACAddress")]
		string WiFiMACAddress{ get; set; }
		// Get WiFi Netmask Address
		[Export ("wiFiNetmaskAddress")]
		string WiFiNetmaskAddress{ get; set; }
		// Get WiFi Broadcast Address
		[Export ("wiFiBroadcastAddress")]
		string WiFiBroadcastAddress{ get; set; }
		// Connected to WiFi?
		[Export ("connectedToWiFi")]
		bool ConnectedToWiFi{ get; set; }
		// Connected to Cellular Network?
		[Export ("connectedToCellNetwork")]
		bool ConnectedToCellNetwork{ get; set; }

		#endregion

		/* Process Information */

		#region Process information

		// Process ID
		[Export ("processID")]
		int ProcessID{ get; set; }
		// Process Name
		[Export ("processName")]
		string ProcessName{ get; set; }
		// Process Status
		[Export ("processStatus")]
		int ProcessStatus{ get; set; }
		// Parent Process ID
		[Export ("parentPID")]
		int ParentPID{ get; set; }
		// List of process information including PID's, Names, PPID's, and Status'
		[Export ("processesInformation")]
		NSMutableArray ProcessesInformation{ get; set; }

		#endregion

		/* Disk Information */

		#region Disk Information

		// Total Disk Space
		[Export ("diskSpace")]
		string  DiskSpace{ get; set; }
		// Total Free Disk Space (Raw)
		[Export ("freeDiskSpaceinRaw")]
		string FreeDiskSpaceInRaw{ get; set; }
		// Total Free Disk Space (Percentage)
		[Export ("freeDiskSpaceinPercent")]
		string FreeDiskSpaceInPercent{ get; set; }
		// Total Used Disk Space (Raw)
		[Export ("usedDiskSpaceinRaw")]
		string UsedDiskSpaceInRaw{ get; set; }
		// Total Used Disk Space (Percentage)
		[Export ("usedDiskSpaceinPercent")]
		string UsedDiskSpaceInPercent{ get; set; }
		// Get the total disk space in long format
		[Export ("longDiskSpace")]
		long LongDiskSpace{ get; set; }
		// Get the total free disk space in long format
		[Export ("longFreeDiskSpace")]
		long LongFreeDiskSpace{ get; set; }

		#endregion

		/* Memory Information */

		#region Memory Information

		// Total Memory
		[Export ("totalMemory")]
		double TotalMemory{ get; set; }
		// Free Memory (Raw)
		[Export ("freeMemoryinRaw")]
		double FreeMemoryInRaw{ get; set; }
		// Free Memory (Percent)
		[Export ("freeMemoryinPercent")]
		double FreeMemoryInPercent{ get; set; }
		// Used Memory (Raw)
		[Export ("usedMemoryinRaw")]
		double UsedMemoryInRaw{ get; set; }
		// Used Memory (Percent)
		[Export ("usedMemoryinPercent")]
		double UsedMemoryInPercent{ get; set; }
		// Active Memory (Raw)
		[Export ("activeMemoryinRaw")]
		double ActiveMemoryInRaw{ get; set; }
		// Active Memory (Percent)
		[Export ("activeMemoryinPercent")]
		double ActiveMemoryInPercent{ get; set; }
		// Inactive Memory (Raw)
		[Export ("inactiveMemoryinRaw")]
		double InactiveMemoryInRaw{ get; set; }
		// Inactive Memory (Percent)
		[Export ("inactiveMemoryinPercent")]
		double InactiveMemoryInPercent{ get; set; }
		// Wired Memory (Raw)
		[Export ("wiredMemoryinRaw")]
		double WiredMemoryInRaw{ get; set; }
		// Wired Memory (Percent)
		[Export ("wiredMemoryinPercent")]
		double WiredMemoryInPercent{ get; set; }
		// Purgable Memory (Raw)
		[Export ("purgableMemoryinRaw")]
		double PurgableMemoryInRaw{ get; set; }
		// Purgable Memory (Percent)
		[Export ("purgableMemoryinPercent")]
		double PurgableMemoryInPercent{ get; set; }

		#endregion

		/* Accelerometer Information */

		#region Accelerometer Information

		// Device Orientation
		[Export ("deviceOrientation")]
		UIInterfaceOrientation DeviceOrientation{ get; set; }

		#endregion

		/* Localization Information */

		#region Localization Information

		// Country
		[Export ("country")]
		string Country{ get; set; }
		// Language
		[Export ("language")]
		string Language{ get; set; }
		// TimeZone
		[Export ("timeZoneSS")]
		string TimeZoneSS{ get; set; }
		// Currency Symbol
		[Export ("currency")]
		string Currency{ get; set; }

		#endregion

		/* Application Information */

		#region Application Information

		// Application Version
		[Export ("applicationVersion")]
		string ApplicationVersion{ get; set; }
		// Clipboard Content
		[Export ("clipboardContent")]
		string ClipboardContent{ get; set; }

		#endregion

		/* Universal Unique Identifiers */

		#region Universal Unique Identifiers

		// Unique ID
		[Export ("uniqueID")]
		string UniqueID{ get; set; }
		// Device Signature
		[Export ("deviceSignature")]
		string DeviceSignature{ get; set; }
		// CFUUID
		[Export ("cfuuid")]
		string Cfuuid{ get; set; }

		#endregion

		[Static, Export ("sharedServices")]
		SystemServices SharedServices ();
	}
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
}

