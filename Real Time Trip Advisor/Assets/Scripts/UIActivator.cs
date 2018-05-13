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
    public GameObject landmarks;


    private bool menuActive = false;
    private bool triviaActive = false;
    private bool logInActive = false;
    private bool aboutActive = false;
    private bool landmarksActive = false;


    public void LandMarks()
    {
        if (!landmarksActive)
        {
            landmarks.SetActive(true);
            landmarksActive = true;
        }
        else if (landmarksActive)
        {
            landmarks.SetActive(false);
            landmarksActive = false;
            triviaActive = false;
            trivia.SetActive(false);
            aboutActive = false;
            trivia.SetActive(false);
        }
    }

    //Used for toggling the settings menu on and off
    public void MenuVar()
    {
        if (!menuActive)
        {
            menu.SetActive(true);
            menuActive = true;
        }
        else
        {
            menu.SetActive(false);
            menuActive = false;
        }
    }

    //Used for toggling the login screen on and off
    public void LogInVar()
    {
        if (!logInActive)
        {
            logIn.SetActive(true);
            logInActive = true;
            menu.SetActive(false);
            menuActive = false;
        }
        else
        {
            logIn.SetActive(false);
            logInActive = false;
			menu.SetActive(true);
			menuActive = true;
        }
    }

    //Used for toggling About the Region on and off
    public void AboutVar()
    {
        if (!aboutActive)
        {
            aboutActive = true;
            about.SetActive(true);
        }
        else
        {
            aboutActive = false;
            about.SetActive(false);
        }
    }

    //Used for toggling Trivia on and off
    public void TriviaVar()
    {
        if (!triviaActive)
        {
            trivia.SetActive(true);
            triviaActive = true;
        }
        else
        {
            trivia.SetActive(false);
            triviaActive = false;
        }
    }
}