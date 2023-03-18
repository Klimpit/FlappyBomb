using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class MenuButtons : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }   
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("exit");
    }
    public void MenuPressed()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public virtual void PressedByKey(string nameOfMethod, bool key, bool additionalCondition)
    {
        if(key && additionalCondition)
        {
            Invoke(nameOfMethod, 0.001f);
        }
    }
}
