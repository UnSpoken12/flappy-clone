using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Spawner spawner;

    public void StartButtonPressed()
    {
        spawner.SetSpawning(true);
        gameObject.SetActive(false);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }
}
