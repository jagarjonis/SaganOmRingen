using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menucontroller: MonoBehaviour
{
    public void menuChoice ()
    {
        SceneManager.LoadScene(1);

    }

    public void mainMenu ()
    {
        SceneManager.LoadScene(0);

    }

    public void quitGame()
    {
        Application.Quit();


    }
    



}


