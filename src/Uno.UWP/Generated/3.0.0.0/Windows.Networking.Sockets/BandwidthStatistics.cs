#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct BandwidthStatistics 
	{
		// Forced skipping of method Windows.Networking.Sockets.BandwidthStatistics.BandwidthStatistics()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong OutboundBitsPerSecond;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong InboundBitsPerSecond;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong OutboundBitsPerSecondInstability;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong InboundBitsPerSecondInstability;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  bool OutboundBandwidthPeaked;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  bool InboundBandwidthPeaked;
		#endif
	}
}
