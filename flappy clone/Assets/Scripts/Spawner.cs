using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    private bool isSpawning = false;

    private IEnumerator SpawnO()
    {
        yield return new WaitForSeconds(5);
        while (isSpawning)
        {
            Instantiate(spawnPrefab, transform);
            yield return new WaitForSeconds(Random.Range(2, 6));
        }
        yield return null;
    }

    public void SetSpawning(bool newState)
    {
        isSpawning = newState;
        StartCoroutine(nameof(SpawnO));
    }
}
