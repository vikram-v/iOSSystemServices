using System;

namespace SystemServicesBinding
{
	public partial class SystemServices
	{
		public static SystemServices Instance { 
			get {
				return SharedServices ();
			}
		}
	}
}

