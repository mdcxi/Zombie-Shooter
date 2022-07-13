using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

        enabled = false;
    }

    public void QuitGame ()
    {

        SceneManager.LoadScene(1);
        Time.timeScale = 1;

        enabled = false;
        //Debug.Log("Quit Game");
        //Application.Quit();

    }
}
