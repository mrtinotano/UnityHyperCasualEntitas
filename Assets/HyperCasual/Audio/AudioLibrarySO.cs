using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HyperCasual.Sound
{
    [CreateAssetMenu(fileName = "Audio Library", menuName = "Hyper Casual/Audio/Audio Library")]
    public class AudioLibrarySO : ScriptableObject
    {
        [Serializable]
        private struct AudioInfo
        {
            public string Key;
            public AudioClip Clip;
        }

        [SerializeField] private AudioInfo[] Audios;

        public AudioClip GetAudio(string key) => Array.Find(Audios, x => x.Key == key).Clip;
        public AudioClip GetRandomAudio() => Audios[UnityEngine.Random.Range(0, Audios.Length)].Clip;
    }
}
