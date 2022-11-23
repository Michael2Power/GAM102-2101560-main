using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Stuggs");
    }

    public void Quitgame ()
      {
        Debug.Log("Quitting Game");
        Application.Quit();
      }

}
