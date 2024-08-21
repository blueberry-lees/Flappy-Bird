using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public int flappyScore;
    public TextMeshProUGUI scoreCount;


    void score()
    {
        flappyScore += 1;

        scoreCount.text = "Score:" + flappyScore;

    }

    private void Start()
    {
        flappyScore = 0;    
    }


}
