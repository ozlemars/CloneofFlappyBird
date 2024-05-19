using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnCloud();
    }


    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }
    void spawnCloud()
    {
        float lowstPoint = transform.position.y - heightOffset;
        float highstPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowstPoint, highstPoint), 0), transform.rotation);
    }
}
