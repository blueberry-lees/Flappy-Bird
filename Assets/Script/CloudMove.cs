using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float deadAhh;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;


        if (transform.position.x < deadAhh)
        {
            Destroy(gameObject);
        }

    }
}
