using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.GUI
{
    public class AudioButtonController : ButtonController
    {
        [SerializeField] private GameObject m_AudioOff;

        protected override void OnButtonClick()
        {
            m_AudioOff.SetActive(!m_AudioOff.activeInHierarchy);
            AudioListener.volume = 1 - AudioListener.volume;
        }
    }
}
