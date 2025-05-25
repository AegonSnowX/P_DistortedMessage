using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public EntitySpawner entitySpawner; // Assign in inspector

    void Update()
    {//Debug.Log(" pressed");
        if (Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Y is pressed");
            int cam = Random.Range(0, 6);
            Color c = Random.value > 0.5f ? Color.red : Color.green;
            entitySpawner.SpawnEntityOnCamera(cam, c);
        }
    }
    public void Spawn()
    {
            Debug.Log("Y is pressed");
            int cam = Random.Range(0, 6);
            Color c = Random.value > 0.5f ? Color.red : Color.green;
            entitySpawner.SpawnEntityOnCamera(cam, c); 
    }
}
