using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeInit : MonoBehaviour
{
    [SerializeField] private string volumeParameter = "Master";
    [SerializeField] private AudioMixer mixer;
    void Start()
    {
        var volumeValue = PlayerPrefs.GetFloat(volumeParameter, 0f);
        mixer.SetFloat(volumeParameter, volumeValue);
    }

}
