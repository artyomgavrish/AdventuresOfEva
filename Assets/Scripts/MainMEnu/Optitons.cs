using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Optitons : MonoBehaviour
{
    [SerializeField] private bool FullScreen;
    public AudioMixer am;
    public void FullScreenToggle()
    {
        FullScreen = !FullScreen;
        Screen.fullScreen = FullScreen;
    }
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("MasterVolume", sliderValue);
    }
}
