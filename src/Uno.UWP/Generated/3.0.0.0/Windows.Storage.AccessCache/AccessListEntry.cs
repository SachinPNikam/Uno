#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.AccessCache
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct AccessListEntry 
	{
		// Forced skipping of method Windows.Storage.AccessCache.AccessListEntry.AccessListEntry()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  string Token;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  string Metadata;
		#endif
	}
}
