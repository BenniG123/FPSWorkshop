using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;
    public List<Transform> spawnPoints;
    private int level;

	// Use this for initialization
	void Start () {
        level = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] g = GameObject.FindGameObjectsWithTag("Enemy");
        print(g);

        if (g.Length == 0)
        {
            level++;
            SpawnEnemies(level);
        }
	}

    private void SpawnEnemies(int level)
    {
        for (int i = 0; i < level * 2; i++)
        {
            int spawnPoint = i % spawnPoints.Count;
            Instantiate(enemy, spawnPoints[spawnPoint].position, spawnPoints[spawnPoint].rotation);
        }
    }
}
