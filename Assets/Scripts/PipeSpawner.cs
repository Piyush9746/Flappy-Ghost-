using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour

{
    
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightoffset = 1;


    // Start is called before the first frame update
    void Start()
    {
       

    }

    private void spawnpipe()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();

            timer = 0;

        }
        void spawnPipe()
        {   
            float lowestPoint = transform.position.y -heightoffset;
            float highestPoint = transform.position.y +heightoffset;
            Instantiate(pipe,new Vector3(transform.position.x,UnityEngine.Random.Range(lowestPoint,highestPoint),0), transform.rotation);
        }
    }
}