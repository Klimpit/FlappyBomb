using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MenuButtons
{
    [SerializeField] private Canvas settings;
    [SerializeField] private Canvas mainMenu;

    public void SettingPressed()
    {
        settings.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        Debug.Log("Settings");
        sound.Play();
    }
    public void StatsPressed()
    {
        Debug.Log("Statistic");
        sound.Play();
    }

    public void ClosePressed()
    {
        Time.timeScale = 1.0f;
        settings.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        sound.Play();
    }
}