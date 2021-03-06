﻿/*
*(Christopher Green)
*(ButtonBehaviour.cs)
* (Assignment 4)
* (This scripts contains the basic information and functionality of any buttons of any menu. (main menu and game over menu))
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{

    AudioManager audioMan;


    public void Start()
    {
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
