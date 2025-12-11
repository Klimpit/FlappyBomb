using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CrashMenu : MenuInGame, IInGameObserver
{
    [SerializeField] private TMP_Text highestScore;
    [SerializeField] private TMP_Text currentScore;
    public void Restart()
    {
        StartCoroutine(PBC.ButtonCoroutine(RestartGame, sound));
    }
    public void UpdateOnEndGame()
    {
        GetComponent<Canvas>().enabled = true;
        highestScore.text = Score.MaxScore.ToString();
        currentScore.text = Score.CurrentScore.ToString();
    }
    public void UpdateOnStartGame() { }
    private void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
