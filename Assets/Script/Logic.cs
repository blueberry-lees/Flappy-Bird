using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;


public class Logic : MonoBehaviour
{

    public int flappyScore;
    public TextMeshProUGUI scoreCount;

    public GameObject gameOverScreen;
    public AudioManager audioScript;

    public Camera mainCamera;
    public Color newColor;

    void Start()
    {
        flappyScore = 0;
        audioScript = GameObject.FindGameObjectWithTag("Audio Manager").GetComponent<AudioManager>();
  
    }


    public void addScore()
    {
        flappyScore += 1;

        scoreCount.text = "Score: " + flappyScore;
        audioScript.ScoreBell();
    }


    public void tryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        audioScript.FailBell();
  
        mainCamera.backgroundColor = newColor;
    }



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
