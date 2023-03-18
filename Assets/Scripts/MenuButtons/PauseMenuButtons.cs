using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuButtons : MenuButtons
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Canvas pausePanel;
    private void Update()
    {
        PressedByKey(nameof(PausePressed), Input.GetKeyUp(KeyCode.Escape), pausePanel.isActiveAndEnabled == false);
        PressedByKey(nameof(ResumePressed), Input.GetKeyUp(KeyCode.Escape), pausePanel.isActiveAndEnabled);
        PressedByKey(nameof(PlayPressed), Input.GetKeyUp(KeyCode.Space), Crash.isHadCrashed);
    }
    public void ResumePressed()
    {
        if(Crash.isHadCrashed ==false)
        {
            Time.timeScale = 1f;
            pauseButton.gameObject.SetActive(true);
            pausePanel.gameObject.SetActive(false);
            Debug.Log("Start");
        }
    }
    public void PausePressed()
    {
        if (Crash.isHadCrashed == false)
        {
            Time.timeScale = 0f;
            pauseButton.gameObject.SetActive(false);
            pausePanel.gameObject.SetActive(true);
            Debug.Log("Stop");
        }
    }
}
