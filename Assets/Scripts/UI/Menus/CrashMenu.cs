using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashMenu : MenuInGame, IObserver
{
    public void Restart()
    {
        StartCoroutine(PBC.ButtonCoroutine(RestartGame, sound));
    }
    public void UpdateOnEndGame()
    {
        GetComponent<Canvas>().enabled = true;
    }
    public void UpdateOnStartGame() { }
    private void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
