#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum UserNotificationChangedKind 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Added,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Removed,
		#endif
	}
	#endif
}
