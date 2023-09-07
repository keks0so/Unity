using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System;
using Random = UnityEngine.Random;


public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyGO;
    public GameObject MeteorGO;
    public float maxSpawnRateInSeconds;
    int rnd;

    float maxSpeedRateInSeconds = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke ("SpawnEnemy", maxSpeedRateInSeconds);

        //increse spawn rate every 30 seconds
        //InvokeRepeating ("IncreaseSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int rnd = Random.Range(0, 2);

        // the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

        // this is the top right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
        if (rnd == 0)
        {
            GameObject anEnemy = (GameObject)Instantiate(MeteorGO);
            anEnemy.transform.position = new Vector2(Random.Range(min.x + 0.255f, max.x - 0.255f), max.y);

            //Sheadule when to spaen next enemy
            ScheduleNextEnemySpawn();
        }
        //instantiate an enemy
        if (rnd == 1)
        {
            GameObject anEnemy = (GameObject)Instantiate(EnemyGO);
            anEnemy.transform.position = new Vector2(Random.Range(min.x + 0.255f, max.x - 0.255f), max.y);

            //Sheadule when to spaen next enemy
            ScheduleNextEnemySpawn();
            
        }
        
    }
    
    float spawnInNSeconds;

    void ScheduleNextEnemySpawn()
    {
        

        if(maxSpawnRateInSeconds > 1f)
        {
            spawnInNSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawnInNSeconds = 1f;
        
        Invoke ("SpawnEnemy", spawnInNSeconds);
    }

    void IncreaseSpawnRate()
        {
            if(maxSpawnRateInSeconds > 1f)
            {
                maxSpawnRateInSeconds--;
            }
                
            
            if(maxSpawnRateInSeconds == 1f)
            {
                CancelInvoke("IncreaseSpawnRate");
            }
                
        }

    //Function to start enemy spawner
    public void ScheduleEnemySpawner()
    {
        Invoke ("SpawnEnemy", maxSpeedRateInSeconds);

        //increse spawn rate every 30 seconds
        InvokeRepeating ("IncreaseSpawnRate", 0f, 30f);
    }
    
    //Function to stop enemy spawner
    public void UnscheduleEnemySpawner()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");

    }

}

