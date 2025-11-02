using UnityEngine;
using UnityEngine.Audio;

public class GameParameters : MonoBehaviour
{
    public string[] VolumeParameters;
    public AudioMixer Mixer;
    private void Start()
    {
        SetSoundParameters();
    }

    private void SetSoundParameters()
    {
        for (int i = 0; i < VolumeParameters.Length; i++)
        {
            var volumeValue = PlayerPrefs.GetFloat(VolumeParameters[i], 0f);
            Mixer.SetFloat(VolumeParameters[i], volumeValue);
        }
    }
}
