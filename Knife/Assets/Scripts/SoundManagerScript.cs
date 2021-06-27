using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerFire, enemyDeath;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        playerFire = Resources.Load<AudioClip>("GUNPis_Shot in 357 magnum 9 mm (ID 0438)_BSB");
        enemyDeath = Resources.Load<AudioClip>("mixkit-fast-game-explosion-1688");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot(playerFire);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(enemyDeath);
                break;

        }

    }
}
