using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
    private float timeBetweenSpawns = 0.0f;
    private float gameTimer = 0.0f;
    private bool gameIsRunning = false;

    [SerializeField]
    private GameObject platformPrefab;
    [SerializeField]
    private float spawnTimer = 5.0f;
    [SerializeField]
    private Transform spawnPoint;

	// For initialization
	void Start () {
      
	}
	
	// Update
	void Update () {
        gameTimer += Time.deltaTime;
        if (gameTimer >= 1.0f) {
            gameIsRunning = true;
        }
        if (gameIsRunning){
            timeBetweenSpawns += Time.deltaTime;
            if (timeBetweenSpawns >= spawnTimer){ 
                Instantiate(platformPrefab, spawnPoint);
                timeBetweenSpawns = 0.0f;
            }
        }
	}
}
