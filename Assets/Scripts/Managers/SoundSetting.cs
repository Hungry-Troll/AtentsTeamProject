using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSetting : MonoBehaviour
{
    private static readonly string PlayLog = "PlayLog";
    private static readonly string BGMPref = "BGMPref";
    private static readonly string SFXPref = "SFXPref";
    private float BGMSliderValue, SFXSliderValue;
    public AudioSource BGMAudioSource;
    public AudioSource[] SFXAudioArray;

    // Start is called before the first frame update
    void Awake()
    {
        ContinueSetting();
    }
    
    private void ContinueSetting()
    {
        BGMSliderValue = PlayerPrefs.GetFloat(BGMPref);
        SFXSliderValue = PlayerPrefs.GetFloat(SFXPref);

        BGMAudioSource.volume = BGMSliderValue;

        for(int i = 0; i < SFXAudioArray.Length; i++)
        {
            SFXAudioArray[i].volume = SFXSliderValue;
        }
    }
}
