using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class PlayerMovements : MonoBehaviour
{

    public int jumpForce;
    public int rotationForce;

    public Rigidbody2D rb;

    public Logic logicScript;

    public bool livelyBird = true;
    public bool hasRun = false;


    public AudioManager audioScript;

    void Start()
    {

        transform.position = new Vector3(0,0,0);
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        audioScript = GameObject.FindGameObjectWithTag("Audio Manager").GetComponent<AudioManager>();
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && livelyBird == true)
        {
            Debug.Log("Jump!");
            rb.velocity = (Vector2.up * jumpForce);
            audioScript.ChirpClip();
            
        }
    }
   

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("HitScore") && livelyBird == true)
        {
            Debug.Log("Score!");

            logicScript.addScore();

        }


        if (collision.CompareTag("DeathHit") && hasRun == false)
        {
            Debug.Log("Dead!");

            logicScript.gameOver();
            livelyBird = false;
            hasRun = true;
        }





    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y  * rotationForce);
        
    }
    //transform.localEulerAngles = new Vector3(0, 0, 0);
}
