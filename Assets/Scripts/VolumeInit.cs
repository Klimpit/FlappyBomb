using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeInit : MonoBehaviour
{
    [SerializeField] string volumeParameter = "Master";
    [SerializeField] AudioMixer mixer;
    void Start()
    {
        var volumeValue = PlayerPrefs.GetFloat(volumeParameter, 0f);
        mixer.SetFloat(volumeParameter, volumeValue);
    }

}
