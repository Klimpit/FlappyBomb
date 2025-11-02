using UnityEngine;
using UnityEngine.UI;

public class ToggleChanger : MonoBehaviour
{
    [SerializeField] private Toggle fullscreen;
    private bool isFullscreen;
    private void Awake()
    {
        fullscreen.onValueChanged.AddListener(SetFullScreen);
    }
    void Start()
    {
        isFullscreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullScreen"));
        fullscreen.isOn = isFullscreen;
    }
    public void SetFullScreen(bool isFullScreen)
    {
        isFullscreen = isFullScreen;
        Screen.fullScreen = this.isFullscreen;
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("FullScreen", System.Convert.ToInt32(isFullscreen));
    }
}
