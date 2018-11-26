﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerLvl2 : MonoBehaviour
{
    public GameObject enemyGo;
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject miniBoss;

    public int hazardCount = 10;
    public int waveCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int counter = 0;

    float maxSpawnSec = 3f;
    float maxAstSpawn = 10f;
    int random_number;

    int i = 0;
    int j = 0;
    int totalWave = 3;
    int miniCount = 2;
    // Use this for initialization
    void Start()
    {
        //Invoke("SpawnEnemy", maxSpawnSec);
        //Invoke("SpawnAsteroid", maxAstSpawn);
        //Invoke("SpawnAsteroid2", maxAstSpawn);

        Debug.Log("works till here");
        StartCoroutine(SpawnWaves());
        //InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        hazardCount = 5;
        spawnWait = 1.5f;
        while (i < hazardCount)
        {
            random_number = Random.Range(1, 100);
            //Debug.Log("Random number is: " + random_number);
            if (random_number > 0 && random_number < 81)
            {
                Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(.2f, 0));
                Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(.8f, 1));
                GameObject anEnemy = (GameObject)Instantiate(enemyGo);
                anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            }
            else if (random_number > 80 && random_number < 91)
            {
                Vector2 min2 = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                Vector2 max2 = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                GameObject anAst = (GameObject)Instantiate(asteroid1);
                anAst.transform.position = new Vector2(Random.Range(min2.x, max2.x), max2.y);
            }
            else if (random_number > 90 && random_number <= 100)
            {
                Vector2 min3 = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                Vector2 max3 = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                GameObject anAst2 = (GameObject)Instantiate(asteroid2);
                anAst2.transform.position = new Vector2(Random.Range(min3.x, max3.x), max3.y);
            }
            Debug.Log(i + " is the answer");
            Debug.Log(hazardCount + " is the needed");
            yield return new WaitForSeconds(spawnWait);
        }
        hazardCount = 5;
        yield return new WaitForSeconds(waveWait);
        i = 0;
        spawnWait = 1.5f;

        // Second round of wave 
        while (i < hazardCount)
        {
            random_number = Random.Range(1, 100);
            //Debug.Log("Random number is: " + random_number);
            if (random_number > 0 && random_number < 91)
            {
                Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(.2f, 0));
                Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(.8f, 1));
                GameObject anEnemy = (GameObject)Instantiate(enemyGo);
                anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            }
            else if (random_number > 90 && random_number < 96)
            {
                Vector2 min2 = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                Vector2 max2 = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                GameObject anAst = (GameObject)Instantiate(asteroid1);
                anAst.transform.position = new Vector2(Random.Range(min2.x, max2.x), max2.y);
            }
            else if (random_number > 95 && random_number <= 100)
            {
                Vector2 min3 = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                Vector2 max3 = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                GameObject anAst2 = (GameObject)Instantiate(asteroid2);
                anAst2.transform.position = new Vector2(Random.Range(min3.x, max3.x), max3.y);
            }
            Debug.Log(i + " is the answer");
            Debug.Log(hazardCount + " is the needed");
            yield return new WaitForSeconds(spawnWait);
        }

        yield return new WaitForSeconds(waveWait);
        i = 0;
 
        for(i = 0; i < miniCount; ++i)
        {
            Vector2 min4 = Camera.main.ViewportToWorldPoint(new Vector2(.2f, 0));
            Vector2 max4 = Camera.main.ViewportToWorldPoint(new Vector2(.8f, 1));
            GameObject miniBoss_ = (GameObject)Instantiate(miniBoss);
            if (i == 0)
            {
                miniBoss_.transform.position = new Vector2(min4.x, max4.y);
            }
            else
            {
                miniBoss_.transform.position = new Vector2(max4.x, max4.y);
            }
        }

        

    }






    public void addCount()
    {
       i = i + 1;
    }
}


