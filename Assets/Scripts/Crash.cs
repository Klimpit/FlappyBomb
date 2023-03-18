using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public static bool isHadCrashed;

    private void Awake()
    {
        isHadCrashed = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.mainTheme.Pause();
        Time.timeScale = 0f;
        isHadCrashed = true;
        Debug.Log("GG!");
    }
}
