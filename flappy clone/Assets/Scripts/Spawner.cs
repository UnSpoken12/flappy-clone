using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Rock spawnPrefab;

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            Instantiate(spawnPrefab, transform);
        }
    }

    public void StartSpawning()
    {
        StartCoroutine(nameof(SpawnObject));
    }

    public void StopSpawning()
    {
        StopAllCoroutines();
        foreach (Rock r in GetComponentsInChildren<Rock>()) { r.SetSpeed(0); }
    }
}
