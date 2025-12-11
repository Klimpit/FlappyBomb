using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class GameManager : MonoBehaviour, ISubject
{
    private List<IInGameObserver> InGameObservers;
    private Score score;
    public static bool IsGamePaused { get; private set; }
    public static bool IsGameStarted { get; private set; }

    private void Awake()
    {
        score = Score.GetInstance();
        InGameObservers = new();
        IsGamePaused = false;
        IsGameStarted = false;
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
    public void AddObserver(IInGameObserver observer) => InGameObservers.Add(observer);
    public void RemoveObserver(IInGameObserver observer) => InGameObservers.Remove(observer);
    private void NotifyAboutEnd()
    {
        foreach (var observer in InGameObservers)
        {
            observer.UpdateOnEndGame();
        }
    }
    private void NotifyAboutStart()
    {
        foreach (var observer in InGameObservers)
        {
            observer.UpdateOnStartGame();
        }
    }
}
