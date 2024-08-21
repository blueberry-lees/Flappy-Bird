using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;

    public float offsetHeight;




    public float spawnRate; //set time to trigger spawn
    float timer; //to count up the time


    void Start()
    {
        spawnPipe();
    }

    void Update()
    {

        if ( timer < spawnRate)
        {
            timer += Time.deltaTime; //to increase number according to delta time

        }
        else
        {
            spawnPipe();
            timer = 0;
        }



    }

    void spawnPipe() //just to make things(funtion) easier to paste
    {


        float highestPoint = transform.position.y + offsetHeight;
        float lowestPoint = transform.position.y - offsetHeight;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestPoint, lowestPoint), 0 ), transform.rotation);

    }
}


