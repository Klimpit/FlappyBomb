using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MenuInGame
{
    public void Resume()
    {
        StartCoroutine(PBC.ButtonCoroutine(ResumeGame, sound));
    }

    private void ResumeGame()
    {
        this.gameObject.SetActive(false);
    }
}
