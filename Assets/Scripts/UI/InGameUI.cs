using TMPro;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text tmp;
    [SerializeField] private GameManager gm;
    [SerializeField] private Canvas pauseMenu;

    private PressButtonCoroutine PBC;

    [SerializeField] private AudioSource sound;

    private void Awake()
    {
        PBC = new();
    }
    public void Pause()
    {
        StartCoroutine(PBC.ButtonCoroutine(PauseGame, sound));
    }

    private void PauseGame()
    {
        gm.StopResumeGame();
        pauseMenu.gameObject.SetActive(true);
    }
}
