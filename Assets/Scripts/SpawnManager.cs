using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRangeY = 5f;
    private float spawnPosX = 13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            
            SpawnEnemy();
            
        }
    }

    private void FixedUpdate()
    {
        
        
    }

   

    private void SpawnEnemy()
    {
        Vector2 spawnpos = new Vector2(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(enemyPrefab, spawnpos, enemyPrefab.transform.rotation);
    }
}
