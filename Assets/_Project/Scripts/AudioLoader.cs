using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    [SerializeField] private List<AudioLoad> loads = new List<AudioLoad>();

    private void Start() {
        foreach(AudioLoad load in loads) {
            AudioManager.loadAudio(load.clipName, load.source);
        }
    }





    [System.Serializable]
    public class AudioLoad
    {
        public AudioSource source;
        public string clipName;

        private void Start() {
            AudioManager.loadAudio(clipName, source);
        }
    }

}
