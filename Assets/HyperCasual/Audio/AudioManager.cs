using HyperCasual.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using HyperCasual.Game;

namespace HyperCasual.Sound
{
    public class AudioManager : MonoBehaviour
    {
        [Serializable]
        private struct AudioLibrary
        {
            public string Key;
            public AudioLibrarySO Library;
        }

        [SerializeField] private AudioLibrary[] m_AudioLibraries;

        public static AudioManager Instance { get; private set; }

        private void Awake() => Instance = this;

        public void PlayAudio(string libraryKey, string audioKey)
        {
            AudioClip clip = GetLibrary(libraryKey)?.GetAudio(audioKey);
            PlayAudioInternal(clip);
        }

        public void playRandomAudio(string libraryKey)
        {
            AudioClip clip = GetLibrary(libraryKey)?.GetRandomAudio();
            PlayAudioInternal(clip);
        }

        private AudioLibrarySO GetLibrary(string libraryKey) 
            => Array.Find(m_AudioLibraries, x => x.Key == libraryKey).Library;

        private void PlayAudioInternal(AudioClip clip)
        {
            if (clip == null)
                return;
            GameObject sfx = Pooler.Instance.GetElement("SFX");
            sfx.GetComponent<AudioSource>().PlayOneShot(clip);
        }    
    }
}
