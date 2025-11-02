using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsSubMenu : SubMenu
{
    [SerializeField] private GameParameters gameParameters;
    [SerializeField] private Slider[] Sliders;

    private float[] volumeValue;

    private const float multiplier = 20f;

    private new void Awake()
    {
        base.Awake();
        volumeValue = new float[gameParameters.VolumeParameters.Length];
        SetInitialValueToSliders();
    }
    private void SetInitialValueToSliders()
    {
        for (int i = 0; i < gameParameters.VolumeParameters.Length; i++)
        {
            volumeValue[i] = PlayerPrefs.GetFloat(gameParameters.VolumeParameters[i], Mathf.Log10(Sliders[i].value) * multiplier);
            Sliders[i].value = Mathf.Pow(10f, volumeValue[i] / multiplier);
            Debug.Log(gameParameters.VolumeParameters[i] + " = " + PlayerPrefs.GetFloat(gameParameters.VolumeParameters[i], Mathf.Log10(Sliders[i].value) * multiplier));
        }
    }
    public void MasterChange()
    {
        volumeValue[0] = Mathf.Log10(Sliders[0].value) * multiplier;
        gameParameters.Mixer.SetFloat(gameParameters.VolumeParameters[0], volumeValue[0]);
    }
    public void MusicChange()
    {
        volumeValue[1] = Mathf.Log10(Sliders[1].value) * multiplier;
        gameParameters.Mixer.SetFloat(gameParameters.VolumeParameters[1], volumeValue[1]);
    }
    public void EffectsChange()
    {
        volumeValue[2] = Mathf.Log10(Sliders[2].value) * multiplier;
        gameParameters.Mixer.SetFloat(gameParameters.VolumeParameters[2], volumeValue[2]);
    }

    private void OnDisable()
    {
        for(int i = 0; i < gameParameters.VolumeParameters.Length; i++)
        {
            PlayerPrefs.SetFloat(gameParameters.VolumeParameters[i], volumeValue[i]);
            PlayerPrefs.Save();
        }
    }
}
