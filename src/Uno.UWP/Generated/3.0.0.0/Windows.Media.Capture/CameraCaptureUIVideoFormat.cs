#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum CameraCaptureUIVideoFormat 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Mp4,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Wmv,
		#endif
	}
	#endif
}
