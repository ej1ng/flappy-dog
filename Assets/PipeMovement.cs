using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -55;

    // start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // update is called once per frame
    // In PipeMovement.cs
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    
}
 