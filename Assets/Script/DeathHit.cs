using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHit : MonoBehaviour
{
    public Logic logicScript;


    // Start is called before the first frame update
    void Start()
    {


        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Death!");

            logicScript.gameOver();

        }

    }

}
