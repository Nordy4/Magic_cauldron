using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioClip okObject;
    public AudioClip endLoseGame;
    public AudioClip endWinGame;
    public AudioClip backgroundMusic;
    public AudioClip cauldronSound;    

    private Vector3 cameraPosition;

    void Awake()
    {
        Instance = this; 
        cameraPosition = Camera.main.transform.position; 
        PlaySound(backgroundMusic);
    }
    private void PlaySound(AudioClip clip) 
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition); 
    }

    public void PlayOkObject()
    {
        PlaySound(okObject);
    }

    public void PlayLoseGame()
    {
        PlaySound(endLoseGame);
    }

    public void PlayWinGame()
    {
        PlaySound(endWinGame);
    }

    public void PlayCauldronSound()
    {
        PlaySound(cauldronSound);
    }
}
