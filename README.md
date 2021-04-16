# miniJsonConflicSample

## Reproduce Steps
* Select Mono as Scripting Backend
* Build Android project and run

## Result
```
04-16 14:54:42.897 16572-16572/com.DefaultCompany.miniJsonConflicSample E/Unity: MethodAccessException: Method `Google.MiniJSON.Json.Deserialize(string)' is inaccessible from method `GoogleMobileAds.Common.Utils.CastAssetIDMappings(string)'
        at (wrapper managed-to-native) System.Object.__icall_wrapper_mono_throw_method_access(intptr,intptr)
      at GoogleMobileAds.Common.Utils.CastAssetIDMappings (System.String jsonMappings) [0x00000] in <b12c1b9643d845f19ac2d2c567daabf2>:0 
      at _lrzYIkvPC4Ct86Sgf1d6FlyaJ3M._eXQBkxLYQ0eJrSK9oYuIIkse1ON._yEWsWlmKeotZALIGHFAKgQaP2JP () [0x0001c] in <8f3eaa6ff7794cdc9e7fa259b15563b5>:0 
      at _lrzYIkvPC4Ct86Sgf1d6FlyaJ3M._eXQBkxLYQ0eJrSK9oYuIIkse1ON..ctor (UnityEngine.AndroidJavaObject ) [0x00017] in <8f3eaa6ff7794cdc9e7fa259b15563b5>:0 
      at GoogleMobileAds.Android.AdLoaderClient.onUnifiedNativeAdLoaded (UnityEngine.AndroidJavaObject ad) [0x00030] in <8f3eaa6ff7794cdc9e7fa259b15563b5>:0 
        at (wrapper managed-to-native) System.Reflection.MonoMethod.InternalInvoke(System.Reflection.MonoMethod,object,object[],System.Exception&)
      at System.Reflection.MonoMetho
```
