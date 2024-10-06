using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnRate = 0.5f;
    public float lastSpawnTime = 0;

    private void Start()
    {
        Instantiate(pipePrefab);
    }

    void Update()
    {
        if(Time.time >= lastSpawnTime + spawnRate)
        {
            var pos = transform.position;
            pos.y += Random.Range(-1f, 4f);
            pos.x += Random.Range(-1f, 1.1f);
            //Copies Prefabs
            Instantiate(pipePrefab, pos, Quaternion.identity);
            lastSpawnTime = Time.time;
        }
        
    }
}
