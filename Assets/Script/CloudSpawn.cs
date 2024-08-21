using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud;

    public float offsetRange;

    public float spawnTime;
    public float timer;




    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            spawnCloud();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }


    }


    void spawnCloud()
    { 
       float high = transform.position.y + offsetRange;
       float low = transform.position.y - offsetRange;

    Instantiate(cloud, new Vector3(transform.position.x, Random.Range(high, low), 0), transform.rotation);


    }
}
