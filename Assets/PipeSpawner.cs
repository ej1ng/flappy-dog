using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // update is called once per frame
    void Update()
    {
        // tracks time andspawns pipe every 2 seconds
        if (timer < spawnRate)
        {
            timer += Time.deltaTime; // counts time
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    
    // In PipeSpawner.cs
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}
