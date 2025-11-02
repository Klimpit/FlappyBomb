using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool IsGamePaused { get; private set; }
    public bool IsGameStarted { get; private set; }

    //public uint Score {  get; private set; }

    [SerializeField] private Canvas CrashMenu;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI maxScore;
    [SerializeField] private Button pauseButton;
    public static AudioSource mainTheme;
    public GameObject spawner;

    public static bool firstClick = true;

    private void Awake()
    {
        //Score = 0;
        IsGamePaused = false;
        mainTheme = GetComponent<AudioSource>();
        Time.timeScale = 1f;
        spawner.SetActive(false);
        firstClick = true;
        mainTheme.Play();
        Application.targetFrameRate = 144;
    }
    private void Update()
    {
        FirstClick(Input.GetKeyDown(KeyCode.Space));
        FirstClick(Input.GetMouseButtonDown(0));
        HadCrashed();
    }
    public void StopResumeGame()
    {
        IsGamePaused = !IsGamePaused;
    }
    private void FirstClick(bool key)
    {
        if (firstClick && key && Time.timeScale != 0f)
        {
            spawner.SetActive(true);
            firstClick = false;
        }
    }

    private void HadCrashed()
    {
        if (Crash.isHadCrashed)
        {
            CrashMenu.gameObject.SetActive(true);
            score.text = Score.score.ToString();
            maxScore.text = Score.maxScore.ToString();
            pauseButton.gameObject.SetActive(false);
        }
    }
}
