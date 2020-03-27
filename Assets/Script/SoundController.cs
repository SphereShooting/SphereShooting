using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SoundController : MonoBehaviour
{
    public static int soundNumber = 0;
    public AudioClip enemyDeath;
    public AudioClip enemyShot;
    AudioSource audioSource;

    AudioClip[] AudioArray = new AudioClip[5];


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioArray[1] = enemyDeath;
        AudioArray[2] = enemyShot;

    }

    // Update is called once per frame
    void Update()
    {
        if(soundNumber > 0)
        {
            audioSource.PlayOneShot(AudioArray[soundNumber]);

            soundNumber = 0;
        }
    }
}
