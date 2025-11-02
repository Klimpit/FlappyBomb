using System.Collections;
using UnityEngine;

public abstract class Menu : MonoBehaviour
{
    [SerializeField] protected AudioSource sound;

    protected PressButtonCoroutine PBC;

    protected void Awake()
    {
        PBC = new();
    }

    public void Exit()
    {
        StartCoroutine(PBC.ButtonCoroutine(Application.Quit, sound));
    }
}
