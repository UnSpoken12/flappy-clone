using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseButton;
    private bool isPaused = false;

    public void StartButtonPressed()
    {
        spawner.SetSpawning(true);
        mainMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    public void PauseButtonPressed()
    {
        isPaused = !isPaused;
        Time.timeScale = (isPaused) ? 0 : 1;
    }
}
