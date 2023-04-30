using System;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject pauseTint;
    private bool isPaused = false;

    public event Action gameStarted = delegate { };

    public void StartButtonPressed()
    {
        spawner.SetSpawning(true);
        mainMenu.SetActive(false);
        pauseButton.SetActive(true);
        gameStarted();
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    public void PauseButtonPressed()
    {
        isPaused = !isPaused;
        Time.timeScale = (isPaused) ? 0 : 1;
        pauseTint.SetActive((isPaused) ? true : false);
    }
}
