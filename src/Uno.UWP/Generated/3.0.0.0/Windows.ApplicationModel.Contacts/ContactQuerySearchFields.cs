#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ContactQuerySearchFields 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Name,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Email,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Phone,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		All,
		#endif
	}
	#endif
}