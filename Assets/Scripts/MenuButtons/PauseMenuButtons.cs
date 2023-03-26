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
        PressedByKey(nameof(PausePressed), Input.GetKeyDown(KeyCode.Escape), pausePanel.isActiveAndEnabled == false);
        PressedByKey(nameof(ResumePressed), Input.GetKeyDown(KeyCode.Escape), pausePanel.isActiveAndEnabled);
        PressedByKey(nameof(PlayPressed), Input.GetKeyDown(KeyCode.Space), Crash.isHadCrashed);
    }
    public void ResumePressed()
    {
        if(Crash.isHadCrashed ==false)
        {
            sound.Play();
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
