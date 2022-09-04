using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSliderScript : MonoBehaviour
{
    public AudioMixer titleAudioMixer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void volumControll(float sliderValue)
    {
        titleAudioMixer.SetFloat("Master", Mathf.Log10(sliderValue) * 20);
        titleAudioMixer.SetFloat("BGM", Mathf.Log10(sliderValue) * 20);
        titleAudioMixer.SetFloat("SFX", Mathf.Log10(sliderValue) * 20);
    }
}