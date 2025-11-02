using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class MenuInGame : Menu
{
    public void MainMenu()
    {
        StartCoroutine(PBC.ButtonCoroutine(LoadMainMenuScene, sound));
    }
    private void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
