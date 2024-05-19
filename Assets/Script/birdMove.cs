using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMove : MonoBehaviour
{
    public Rigidbody2D Rb2;
    public float uk;
    public logicScripts logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScripts>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive== true) 
        {
            Rb2.velocity= Vector2.up *uk;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
