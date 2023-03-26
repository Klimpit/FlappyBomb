using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class MenuButtons : MonoBehaviour
{
    public AudioSource sound;
    public float timer = 0f;
    public void PlayPressed()
    {
        Time.timeScale = 1f;
        sound.Play();
        Invoke(nameof(LoadScene), 0.185f);
    }   
    public void ExitPressed()
    {
        sound.Play();
        Invoke(nameof(Exit), 0.185f);
        Debug.Log("exit");
    }
    public void MenuPressed()
    {
        sound.Play();
        Time.timeScale = 1f;
        Invoke(nameof(LoadMenu), 0.15f);
    }
    public virtual void PressedByKey(string nameOfMethod, bool key, bool additionalCondition)
    {
        if(key && additionalCondition)
        {
            Invoke(nameOfMethod, 0.001f);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("play");
    }

    private void Exit()
    {
        Application.Quit();
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
