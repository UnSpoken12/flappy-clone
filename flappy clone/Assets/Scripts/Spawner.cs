using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Rock spawnPrefab;
    private bool isSpawning = false;

    private IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(5);
        while (isSpawning)
        {
            Instantiate(spawnPrefab, transform);
            yield return new WaitForSeconds(Random.Range(2, 6));
        }
        yield return null;
    }

    public void SetSpawning(bool canSpawn)
    {
        isSpawning = canSpawn;
        StartCoroutine(nameof(SpawnObject));
    }
}
