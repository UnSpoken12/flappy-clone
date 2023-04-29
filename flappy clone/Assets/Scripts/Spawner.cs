using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    private float spawnRate = 3f;

    void Start()
    {
        Invoke(nameof(spawnObject), spawnRate);
    }

    private void spawnObject()
    {
        Instantiate(spawnPrefab, transform);
        spawnRate = Random.Range(1f, 5f);
        Invoke(nameof(spawnObject), spawnRate);
    }
}
