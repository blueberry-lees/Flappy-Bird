using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed;

    public float deadAhh;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (transform.position.x < deadAhh)
           {
            Destroy(gameObject);
            }

    }
}
