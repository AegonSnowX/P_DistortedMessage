using System.Collections;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private BaseEntity[] entityPrefabs;
    [SerializeField] private Transform spawnPoint; // temperorary singular spawn point to be changed later to an array of already ste spawn point
    private BaseEntity currentEntity; // current entitiy in the game
    public bool isUnderThreat = false;

    public void Start()
    {
        SpawnRandomEntity();
    }
    public void SpawnEntity(BaseEntity prefab)
    {
        if (currentEntity != null)
        {
            Destroy(currentEntity.gameObject);
        }
        
        currentEntity = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        isUnderThreat = true; //there is entity so there is threat
    }
    
    public void ReportEntity(ReportDecision decision)
    {
        if (currentEntity != null)
        {
            currentEntity.HandleReport(decision);
            Destroy(currentEntity.gameObject); // remove after report
            currentEntity = null;
            StartSpawnDelay(2);
            isUnderThreat = false; //there is no entity so there is threat
        }
    }
    
    public void SpawnRandomEntity()
    {
        int index = Random.Range(0, entityPrefabs.Length);
        SpawnEntity(entityPrefabs[index]);
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