using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    private float spawnRate = 3f;

    public void spawnObject()
    {
        Instantiate(spawnPrefab, transform);
        spawnRate = Random.Range(1f, 5f);
        Invoke(nameof(spawnObject), spawnRate);
    }
}
