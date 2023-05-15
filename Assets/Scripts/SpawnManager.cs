using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bouncerPrefab;
    public GameObject brutePrefab;
    public GameObject gruntPrefab;

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
            SpawnEnemyBouncer();
        }
        if(Input.GetKeyDown(KeyCode.D)) 
        { 
            SpawnEnemyBrute();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnEnemyGrunt();
        }
    }

    private void FixedUpdate()
    {
        
        
    }

   

    private void SpawnEnemyBouncer()
    {
        Vector2 spawnpos = new Vector2(spawnPosX, spawnRangeY);
        Instantiate(bouncerPrefab, spawnpos, bouncerPrefab.transform.rotation);
    }

    private void SpawnEnemyBrute()
    {
        Vector2 spawnpos = new Vector2(spawnPosX, spawnRangeY);
        Instantiate(brutePrefab, spawnpos, brutePrefab.transform.rotation);
    }

    private void SpawnEnemyGrunt()
    {
        Vector2 spawnpos = new Vector2(spawnPosX, spawnRangeY);
        Instantiate(gruntPrefab, spawnpos, gruntPrefab.transform.rotation);
    }
}
