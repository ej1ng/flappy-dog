using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;

    public float deadZoneBottom = -27;
    public float deadZoneTop = 27;

    // start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        // game over if bird is out of bounds
        if (isAlive && (transform.position.y < deadZoneBottom || transform.position.y > deadZoneTop))
        {
            logic.gameOver();
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}