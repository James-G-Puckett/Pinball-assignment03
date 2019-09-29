using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public Dropdown MyDropDown;

    public void Mutator()
    {
        switch (MyDropDown.value)
        {
            case 1:
                SceneManager.LoadScene("Normal");
                break;
            case 2:
                SceneManager.LoadScene("Big Flips");
                break;
            case 3:
                SceneManager.LoadScene("Balls Everywhere");
                break;
            default:
                //MyChoice.text = "Please Select";
                break;
        }
    }
    public void StartPlay()
    {
        SceneManager.LoadScene("Starter Scene");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
