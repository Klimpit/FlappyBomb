using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : Menu
{
    [SerializeField] private Canvas settings;

    public void Settings()
    {
        StartCoroutine(PBC.ButtonCoroutine(OpenSettings, sound));
    }

    public void Play()
    {
        StartCoroutine(PBC.ButtonCoroutine(LoadGameScene, sound));
    }

    private void OpenSettings()
    {
        settings.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}