using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExhibitionUtils
{
    public class SoundSystem
    {
        private AudioSource audioSource;
        private SoundConfig soundConfig;

        public SoundSystem(SoundConfig soundConfig)
        {
            var audioSourceGameObject = new GameObject();
            audioSource = audioSourceGameObject.AddComponent<AudioSource>();
            this.soundConfig = soundConfig;
        }

        public void PlaySound(string soundName)
        {
            if (soundName == null && soundName.Length == 0) {
                // Empty sound / No sound
                return;
            }

            var clip = soundConfig.GetClip(soundName);
            audioSource.PlayOneShot(clip);
        }
    }
}
