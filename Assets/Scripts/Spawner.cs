using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 1f;

    [SerializeField] GameObject enemyPrefab;

    float nextTimeToSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
	{
	    Instantiate(enemyPrefab, transform.position, Quaternion.identity);
	    nextTimeToSpawn = Time.time + 1f / spawnRate;
	}
    }
}
