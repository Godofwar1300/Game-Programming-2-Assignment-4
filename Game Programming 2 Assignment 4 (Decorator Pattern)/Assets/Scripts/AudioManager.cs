/*
*(Christopher Green)
*(AudioManager.cs)
* (Assignment 4)
* (This scripts contains the basic information and functionality of the audio manager.)
*  *This class may or may not be used, it depends on time.*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioSource pizzaTime;

    public AudioClip mainMenuMusic;
    public AudioClip gameMenuMusic;
    public AudioClip gameOverMusic;
    public AudioClip pizzaTimeVoice;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMenuMusic()
    {
        if(SceneManager.GetActiveScene().name == "Main Menu")
        {
            audioSource.clip = mainMenuMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    
    public void PlayGameMusic()
    {
        if(SceneManager.GetActiveScene().name == "Game")
        {
            audioSource.clip = gameMenuMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlayGameOverMusic()
    {
        if(SceneManager.GetActiveScene().name == "Game Over")
        {
            audioSource.clip = gameOverMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlayVoice()
    {
        pizzaTime.clip = pizzaTimeVoice;
        pizzaTime.Play();
    }

}
