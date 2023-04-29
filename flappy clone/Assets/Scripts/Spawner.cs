using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    private float spawnRate = 5f;

    void Start()
    {
        InvokeRepeating(nameof(spawnObject), 4f, spawnRate);
    }

    private void spawnObject()
    {
        Instantiate(spawnPrefab, transform);
    }
}
