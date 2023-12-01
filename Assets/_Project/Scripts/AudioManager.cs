using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    private static Dictionary<string, AudioSource> audioTable = new Dictionary<string, AudioSource>();
    public static void loadAudio(string name, AudioSource source) {
        if(audioTable.ContainsKey(name)) return;
        audioTable.Add(name, source);
    }
    public static void play(string name, bool loop = false) {
        if(audioTable.ContainsKey(name)) {
            audioTable[name].loop = loop;
            audioTable[name].Play();
        }
    }
}
