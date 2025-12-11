using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class GameManager : MonoBehaviour, ISubject
{
    private List<IObserver> Observers;
    public static bool IsGamePaused { get; private set; }
    public static bool IsGameStarted { get; private set; }
    //убрать
    public static AudioSource mainTheme;

    private void Awake()
    {
        Observers = new();
        IsGamePaused = false;
        IsGameStarted = false;
        
        mainTheme = GetComponent<AudioSource>();
        mainTheme.Play();
    }
    private void Start()
    {
        AddObserver(FindAnyObjectByType<Rocket>().GetComponent<Rocket>());
        AddObserver(FindAnyObjectByType<Spawner>().GetComponent<Spawner>());
        AddObserver(FindAnyObjectByType<CrashMenu>().GetComponent<CrashMenu>());
    }
    private void FixedUpdate()
    {
        if (Rocket.IsCrashed)
        {
            NotifyAboutEnd();
        }
    }
    public void StopResumeGame()
    {
        IsGamePaused = !IsGamePaused;
    }
    public void StopResumeGame(CallbackContext context)
    {
        StopResumeGame();
    }
    public void StartTheGame(CallbackContext context)
    {
        if (!IsGameStarted)
        {
            NotifyAboutStart();
            IsGameStarted = true;
        }
    }
    public void AddObserver(IObserver observer) => Observers.Add(observer);
    public void RemoveObserver(IObserver observer) => Observers.Remove(observer);
    private void NotifyAboutEnd()
    {
        foreach (var observer in Observers)
        {
            observer.UpdateOnEndGame();
        }
    }
    private void NotifyAboutStart()
    {
        foreach (var observer in Observers)
        {
            observer.UpdateOnStartGame();
        }
    }
}
