using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIActivator : MonoBehaviour
{
    public GameObject menu;
    public GameObject trivia;
    public GameObject logIn;
    public GameObject about;
    public GameObject toMap;
    private bool menuActive = false;
    private bool triviaActive = false;
    private bool logInActive = false;
    private bool aboutActive = false;
    private bool mapActive = true;
    public void MapVar()
    {
        if (mapActive)
        {
            toMap.SetActive(false);
            mapActive = false;
        }
        else
        {
            toMap.SetActive(true);
            mapActive = true;
            menu.SetActive(false);
            menuActive = false;
            menu.SetActive(false);
        }
    }
    public void MenuVar()
    {
        if (!menuActive)
        {
            menu.SetActive(true);
            menuActive = true;
            toMap.SetActive(false);
            mapActive = false;
            triviaActive = false;
            trivia.SetActive(false);
            aboutActive = false;
            about.SetActive(false);
            logInActive = false;
            logIn.SetActive(false);
        }
        else
        {
            menu.SetActive(false);
            menuActive = false;
        }
    }
    public void LogInVar()
    {
        if (!logInActive)
        {
            logIn.SetActive(true);
            logInActive = true;
            menu.SetActive(false);
        }
        else
        {
            logIn.SetActive(false);
            logInActive = false;
			menu.SetActive(true);
			menuActive = true;
			toMap.SetActive(false);
			mapActive = false;
			triviaActive = false;
			trivia.SetActive(false);
			aboutActive = false;
			about.SetActive(false);
			logInActive = false;
			logIn.SetActive(false);
        }
    }
    public void AboutVar()
    {
        if (!aboutActive)
        {
            about.SetActive(true);
            aboutActive = true;
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
            aboutActive = false;
            about.SetActive(false); 
        }
    }
    public void TriviaVar()
    {
        if (!triviaActive)
        {
            trivia.SetActive(true);
            triviaActive = true;
            menu.SetActive(false);
        }
        else
        {
            trivia.SetActive(false);
            triviaActive = false;
            menu.SetActive(true);
        }
    }
}