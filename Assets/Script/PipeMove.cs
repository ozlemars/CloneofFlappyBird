using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -33;
    void Start()
    {
        
    }

    void Update()
    {
       transform.position=transform.position +(Vector3.left*moveSpeed)*Time.deltaTime; 
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
