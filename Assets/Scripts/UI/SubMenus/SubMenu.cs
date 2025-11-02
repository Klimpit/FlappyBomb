using UnityEngine;

public abstract class SubMenu : MonoBehaviour
{
    [SerializeField] protected AudioSource sound;
    [SerializeField] protected Canvas previousMenu;

    protected PressButtonCoroutine PCB;

    protected void Awake()
    {
        PCB = new();
    }

    public void Close()
    {
        StartCoroutine(PCB.ButtonCoroutine(CloseSubMenu, sound));
    }

    private void CloseSubMenu()
    {
        previousMenu.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
