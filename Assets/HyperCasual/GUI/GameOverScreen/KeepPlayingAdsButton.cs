using HyperCasual.Ads;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.GUI
{
    public class KeepPlayingAdsButton : ButtonController
    {
        private void OnEnable() => IronSourceEvents.onRewardedVideoAdRewardedEvent += RewardedVideoAdRewardedEvent;
        private void OnDisable() => IronSourceEvents.onRewardedVideoAdRewardedEvent -= RewardedVideoAdRewardedEvent;

        protected override void Awake()
        {
#if !UNITY_EDITOR && !UNITY_ANDROID && !UNITY_IOS
            gameObject.SetActive(false);
#endif
            base.Awake();
        }

        private void RewardedVideoAdRewardedEvent(IronSourcePlacement obj) =>
            Contexts.sharedInstance.game.ReplaceGameState(Game.GameStateComponent.GameState.GameRunning);

        protected override void OnButtonClick()
        {
#if UNITY_EDITOR
            RewardedVideoAdRewardedEvent(null);
#else
            AdsManager.Instance.ShowRewardVideo();
#endif
        }
    }
}
