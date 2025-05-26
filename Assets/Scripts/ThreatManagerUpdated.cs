using System.Collections;
using UnityEngine;

public class ThreatManagerUpdated : MonoBehaviour
{
    [SerializeField] private BaseEntity[] entityPrefabs;
    [SerializeField] private Transform[] spawnPoints; // multiple spawn points now
    private BaseEntity currentEntity;
    public bool isUnderThreat = false;

    void Start()
    {
        SpawnRandomEntity();
    }

    public void SpawnEntity(BaseEntity prefab, Transform spawnPoint)
    {
        if (currentEntity != null)
        {
            Destroy(currentEntity.gameObject);
        }

        currentEntity = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        isUnderThreat = true;
    }

    public void SpawnRandomEntity()
    {
        if (spawnPoints.Length == 0 || entityPrefabs.Length == 0)
        {
            Debug.LogWarning("Spawn failed: No spawn points or entity prefabs assigned.");
            return;
        }

        int prefabIndex = Random.Range(0, entityPrefabs.Length);
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        SpawnEntity(entityPrefabs[prefabIndex], spawnPoints[spawnIndex]);
    }

    public void ReportEntity(ReportDecision decision)
    {
        if (currentEntity != null)
        {
            currentEntity.HandleReport(decision);
            Destroy(currentEntity.gameObject);
            currentEntity = null;
            isUnderThreat = false;
            StartSpawnDelay(5);
        }
    }

    public void StartSpawnDelay(float delaySeconds)
    {
        StartCoroutine(SpawnAfterDelay(delaySeconds));
    }

    private IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SpawnRandomEntity();
    }
}
