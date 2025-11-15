using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // as soon as pipe spawns
        // looks through hierarchy to find game object with tag "logic"
        // look through object components to find script of class "LogicScript"
        // once it finds it, it will put it in the reference slot

        // basically just a reference to the LogicScript.cs
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1); // function from logicscript.cs
        }
    }
}
