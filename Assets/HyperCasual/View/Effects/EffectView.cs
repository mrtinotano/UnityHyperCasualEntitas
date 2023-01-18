using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.View
{
    public class EffectView : MonoBehaviour
    {
        [SerializeField] private ParticleSystem m_ParticleSystem;
        
        public delegate void EffectFinish();
        public event EffectFinish OnEffecFinish;

        private void Awake()
        {
            ParticleSystem.MainModule main = m_ParticleSystem.main;
            main.playOnAwake = true;
            gameObject.SetActive(false);
        }

        void OnParticleSystemStopped()
        {
            OnEffecFinish?.Invoke();
            OnEffecFinish = null;
            gameObject.SetActive(false);
        }
    }
}
