using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy, enemy2;
    public bool spawnear = true;
    public Vector3 spawnPoint;
    public int timeTilNextSpawn;
    int x, y;
    float timer = 0;
    public int enemigo;

    void Start()
    {
        timer = 0;
        spawnPoint.x = x;
        timeTilNextSpawn = 2;
    }

    void Update()
    {
        timer += Time.deltaTime;
        enemigo = Random.Range(0, 2);
        Spawn();
    }

    public void Spawn()
    {
        if (timer >= timeTilNextSpawn && spawnear == true)
        {  
            y = Random.Range(0, 6);
          
            if (y == 0)
            {
                x = 0;
                spawnPoint.x = x;
                if(enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }
                  
            if (y == 1)
            {
                x = 2;
                spawnPoint.x = x;
                if (enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }
                
            if (y == 2)
            {
                x = 3;
                spawnPoint.x = x;
                if (enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }

            if (y == 3)
            {
                x = -1;
                spawnPoint.x = x;
                if (enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }

            if (y == 4)
            {
                x = -2;
                spawnPoint.x = x;
                if (enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }

            if (y == 5)
            {
                x = 1;
                spawnPoint.x = x;
                if (enemigo == 0)
                {
                    Instantiate(enemy, spawnPoint, Quaternion.identity);
                }
                else if (enemigo == 1)
                {
                    Instantiate(enemy2, spawnPoint, Quaternion.identity);
                }
            }

            timer = 0;
        }
    }   
}