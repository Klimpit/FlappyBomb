using UnityEngine;

public class Score
{
    private static Score instance;

    public static int CurrentScore { get; private set; }
    public static int MaxScore { get; private set; }

    public Score()
    {
        CurrentScore = 0;
        MaxScore = PlayerPrefs.GetInt("score");
    }
    public static Score GetInstance()
    {
        if (instance == null)
        {
            instance = new Score();
        }
        return instance;
    }
    public static void SetNewScore()
    {
        CurrentScore++;
        if (CurrentScore > MaxScore)
        {
            PlayerPrefs.SetInt("score", CurrentScore);
            MaxScore = PlayerPrefs.GetInt("score");
        }
    }
}
