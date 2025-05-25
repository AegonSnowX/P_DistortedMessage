using UnityEngine;
using System.Collections.Generic;

public class EntitySpawner : MonoBehaviour
{
    public GameObject entityPrefab;
    public Transform[] spawnPoints; // One per camera
    public int maxEntitiesPerCamera = 1;

    private List<Entity>[] activeEntities;

    void Awake()
    {
        activeEntities = new List<Entity>[spawnPoints.Length];
        for (int i = 0; i < spawnPoints.Length; i++)
            activeEntities[i] = new List<Entity>();
    }

    public void SpawnEntityOnCamera(int camIndex, Color color)
    {
        if (activeEntities[camIndex].Count >= maxEntitiesPerCamera)
            return;

        Transform spawnPoint = spawnPoints[camIndex];
        GameObject obj = Instantiate(entityPrefab, spawnPoint.position, spawnPoint.rotation);
        Entity entity = obj.GetComponent<Entity>();
        entity.Assign(camIndex, color);
        Debug.Log("EnitySpawned");
        activeEntities[camIndex].Add(entity);
    }

    public void ReportEntitiesOnCamera(int camIndex, ReportDecision decision)
    {
        foreach (Entity e in activeEntities[camIndex])
        {
            e.HandleReport(decision);
        }

        activeEntities[camIndex].Clear();
    }

}
