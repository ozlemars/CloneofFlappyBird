using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnPipe();
    }

    
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer = timer +Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowstPoint = transform.position.y - heightOffset;
        float highstPoint = transform.position.y + heightOffset;

        Instantiate(pipe,new Vector3( transform.position.x, Random.Range(lowstPoint,highstPoint),0), transform.rotation);
    }
}
