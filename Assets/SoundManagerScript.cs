using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip successSound, footstepsSound, gameoverSound, themeSound, spacebuttonSound, runningSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        successSound = Resources.Load<AudioClip>("success");
        footstepsSound = Resources.Load<AudioClip>("footsteps");
        gameoverSound = Resources.Load<AudioClip>("gameover");
        themeSound = Resources.Load<AudioClip>("theme");
        spacebuttonSound = Resources.Load<AudioClip>("spacebutton");
        runningSound = Resources.Load<AudioClip>("running");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "success":
                audioSrc.PlayOneShot(successSound);
                break;
            case "footsteps":
                audioSrc.PlayOneShot(footstepsSound);
                break;
            case "gameover":
                audioSrc.PlayOneShot(gameoverSound);
                break;
            case "theme":
                audioSrc.PlayOneShot(themeSound);
                break;
            case "spacebutton":
                audioSrc.PlayOneShot(spacebuttonSound);
                break;
            case "running":
                audioSrc.PlayOneShot(runningSound);
                break;

        }
    }
}
