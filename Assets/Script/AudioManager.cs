using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip chirpClip, scoreBell, failBell;


    public void ChirpClip()
    {
        audioSource.clip = chirpClip;
        audioSource.Play();


    }
    public void ScoreBell()
    {
        audioSource.clip = scoreBell;
        audioSource.Play();

    }
    public void FailBell()
    {
        audioSource.clip = failBell;
        audioSource.Play();
    }





}
