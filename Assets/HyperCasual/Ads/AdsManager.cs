using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking.Types;

namespace HyperCasual.Ads
{
    public class AdsManager : MonoBehaviour
    {
        public static AdsManager Instance {get; private set;}

        private void Awake() => Instance = this;

        private void OnEnable()
        {
            IronSourceEvents.onSdkInitializationCompletedEvent += OnSdkInitializationCompletedEvent;
        }

        private void OnDisable()
        {
            IronSourceEvents.onSdkInitializationCompletedEvent -= OnSdkInitializationCompletedEvent;
        }

        void OnApplicationPause(bool isPaused) => IronSource.Agent.onApplicationPause(isPaused);

        private void OnSdkInitializationCompletedEvent() => LoadAds();

        private void LoadAds()
        {
            IronSource.Agent.loadBanner(IronSourceBannerSize.SMART, IronSourceBannerPosition.BOTTOM);
            IronSource.Agent.loadInterstitial();
            IronSource.Agent.loadRewardedVideo();

            IronSourceEvents.onBannerAdLoadedEvent += () => IronSource.Agent.displayBanner();
        }

        public void ShowInterstitial()
        {
            if(IronSource.Agent.isInterstitialReady())
                IronSource.Agent.showInterstitial();
        }

        public void ShowRewardVideo()
        {
            if (IronSource.Agent.isRewardedVideoAvailable())
                IronSource.Agent.showRewardedVideo();
        }
    }
}
