using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;

    public void StartButtonPressed()
    {
        spawner.spawnObject();
        gameObject.SetActive(false);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }
}
