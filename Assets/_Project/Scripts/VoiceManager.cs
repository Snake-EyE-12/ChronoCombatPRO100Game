using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VoiceManager : MonoBehaviour
{
    [SerializeField] private List<VoiceRecording> recordings = new List<VoiceRecording>();
    [SerializeField] private AudioSource audioPlayer;
    [SerializeField][Min(0)] private float typeCharacterDelay;
    private float elapsedTime = 0;
    private TextTyper textTyper;
    

    [ContextMenu(nameof(PlayAudio))]
    private void testPlay() {
        PlayAudio(0);
    }
    public void PlayAudio(int index) {
        if(index >= recordings.Count || index < 0) return;
        //audioPlayer.clip = recordings[index].audio;
        elapsedTime = 0;
        textTyper = new TextTyper(recordings[index].text, recordings[index].textbox);
    }
    private void Update() {
        if(elapsedTime > typeCharacterDelay) {
            elapsedTime = 0;
            if(textTyper != null) textTyper.currentTextbox.text = textTyper.GetTypedText();
        }
        elapsedTime += Time.deltaTime;
    }
    public void Clear() {
        textTyper = null;
    }
}


[System.Serializable] public class VoiceRecording
{
    public TMP_Text textbox;
    public string text = "_";
    public AudioClip audio;
}

public class TextTyper
{
    public TMP_Text currentTextbox;
    private string completeText;
    private int progress = 0;
    public TextTyper(string text, TMP_Text textbox) {
        completeText = text;
        currentTextbox = textbox;
    }
    public string GetTypedText() {
        if(progress >= completeText.Length) return completeText;
        progress++;
        return completeText.Substring(0, progress) + "_";
    }
}