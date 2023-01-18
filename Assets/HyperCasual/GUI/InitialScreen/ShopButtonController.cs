using HyperCasual.GUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BouncingBall
{
    public class ShopButtonController : ButtonController
    {
        [SerializeField] private GameObject m_ShopScreen;

        protected override void OnButtonClick()
            => m_ShopScreen.SetActive(!m_ShopScreen.activeInHierarchy);
    }
}
