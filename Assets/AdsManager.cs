using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour {

	private bool unifiedNativeAdLoaded;
	private UnifiedNativeAd nativeAd;

	string SAMPLE_AD_UNIT = "ca-app-pub-3940256099942544/2247696110";

	void Start () {
		// Initialize the Google Mobile Ads SDK.
		MobileAds.Initialize (initStatus => {

			var statusMap = initStatus.getAdapterStatusMap ();

			foreach (var adapterStatus in statusMap) {

				MonoBehaviour.print ("adapterStatus: " + adapterStatus.Key + " " + adapterStatus.Value.Description);
			}

			RequestNativeAd ();
		});
	}

	void Update () {

		if (this.unifiedNativeAdLoaded) {
			this.unifiedNativeAdLoaded = false;
			// Get Texture2D for icon asset of native ad.
			Texture2D iconTexture = this.nativeAd.GetIconTexture ();

			// Get string for headline asset of native ad.
			string headline = this.nativeAd.GetHeadlineText ();
		}
	}

	private void RequestNativeAd () {
		AdLoader adLoader = new AdLoader.Builder (SAMPLE_AD_UNIT)
			.ForUnifiedNativeAd ()
			.Build ();
		adLoader.OnUnifiedNativeAdLoaded += this.HandleUnifiedNativeAdLoaded;
		adLoader.LoadAd (new AdRequest.Builder ().Build ());
	}

	private void HandleNativeAdFailedToLoad (object sender, AdFailedToLoadEventArgs args) {
		MonoBehaviour.print ("Native ad failed to load: " + args.Message);
	}

	private void HandleUnifiedNativeAdLoaded (object sender, UnifiedNativeAdEventArgs args) {
		MonoBehaviour.print ("Unified native ad loaded.");
		this.nativeAd = args.nativeAd;
		this.unifiedNativeAdLoaded = true;
	}
}
