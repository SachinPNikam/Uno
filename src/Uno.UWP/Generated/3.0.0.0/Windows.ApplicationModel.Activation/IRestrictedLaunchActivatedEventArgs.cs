#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IRestrictedLaunchActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		object SharedContext
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs.SharedContext.get
	}
}
