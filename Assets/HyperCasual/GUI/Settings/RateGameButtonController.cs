using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.GUI
{
    public class RateGameButtonController : ButtonController
    {
        protected override void Awake()
        {
#if !UNITY_EDITOR && !UNITY_ANDROID && !UNITY_IOS
            gameObject.SetActive(false);
#endif
            base.Awake();
        }

        protected override void OnButtonClick()
        {
#if UNITY_ANDROID
            Application.OpenURL($"market://details?id={Application.identifier}");
#elif UNITY_IOS
            Application.OpenURL($"itms-apps://itunes.apple.com/app/{Application.identifier}/1663640601");
#endif
        }
    }
}
