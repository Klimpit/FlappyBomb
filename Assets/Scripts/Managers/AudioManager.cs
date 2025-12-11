using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource menuTheme;
    [SerializeField] private AudioSource inGameTheme;
    [SerializeField] private AudioSource tapScound;
    [SerializeField] private AudioSource scoreScound;

    private void Start()
    {
        SceneManager.sceneLoaded += SetTheme;
        SetTheme();
    }
    public void PlayScoreSound()
    {
        scoreScound.Play();
    }
    private void SetTheme(Scene scene, LoadSceneMode mode)
    {
        SetTheme();
    }
    private void SetTheme()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "MainMenu":
                menuTheme.enabled = true;
                inGameTheme.enabled = false;
                break;
            case "Game":
                menuTheme.enabled = false;
                inGameTheme.enabled = true;
                break;
        }
    }
}
