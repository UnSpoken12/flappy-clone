using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject pauseTint;
    private bool isPaused = false;

    public void StartButtonPressed()
    {
        mainMenu.SetActive(false);
        pauseButton.SetActive(true);
        GameManager.instance.ChangeGameState(State.Start);
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
