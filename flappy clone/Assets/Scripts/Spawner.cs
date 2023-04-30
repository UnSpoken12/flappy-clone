using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    private float spawnRate = 3f;
    private bool isSpawning = false;

    private void SpawnObject()
    {
        if (isSpawning)
        {
            Instantiate(spawnPrefab, transform);
            spawnRate = Random.Range(1f, 5f);
            Invoke(nameof(SpawnObject), spawnRate);
        }
    }

    public void SetSpawning(bool newState)
    {
        isSpawning = newState;
        SpawnObject();
    }
}
