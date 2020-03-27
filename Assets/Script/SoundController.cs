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
    [SerializeField] AudioClip gameOver;
    [SerializeField] AudioClip gameClear;

    AudioSource audioSource;

    AudioClip[] AudioArray = new AudioClip[11];


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
        AudioArray[9] = gameOver;
        AudioArray[10] = gameClear;

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
