using UnityEngine;
using UnityEngine.UI;

public class ToggleInit : MonoBehaviour
{
    void Start()
    {
        Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullScreen", 1));
    }

}
