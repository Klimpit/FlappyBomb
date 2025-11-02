using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashMenu : MenuInGame
{
    public void Restart()
    {
        StartCoroutine(PBC.ButtonCoroutine(RestartGame, sound));
    }
    private void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
