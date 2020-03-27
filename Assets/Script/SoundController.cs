using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SoundController : MonoBehaviour
{
    public static int soundNumber = 0;
    [SerializeField] AudioClip enemyDeath;
    [SerializeField] AudioClip enemyShot;
    [SerializeField] AudioClip playerDamege;
    [SerializeField] AudioClip boss1Shot;
    [SerializeField] AudioClip boss1Death;
    [SerializeField] AudioClip boss1Summon;
    [SerializeField] AudioClip playerDeath;
    [SerializeField] AudioClip gameStart;

    AudioSource audioSource;

    AudioClip[] AudioArray = new AudioClip[9];


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioArray[1] = enemyDeath;
        AudioArray[2] = enemyShot;
        AudioArray[3] = playerDamege;
        AudioArray[4] = boss1Shot;
        AudioArray[5] = boss1Death;
        AudioArray[6] = boss1Summon;
        AudioArray[7] = playerDeath;
        AudioArray[8] = gameStart;

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
