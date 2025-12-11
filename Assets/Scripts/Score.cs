using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    public static int score;
    public static int maxScore;

    private void Awake()
    {
        score = 0;
        maxScore = PlayerPrefs.GetInt("score");
    }

    private void Update()
    {
        scoreBoard.text = score.ToString();
        if(score > maxScore)
        {
            PlayerPrefs.SetInt("score", score);
            maxScore = PlayerPrefs.GetInt("score");
        }
    }
}
