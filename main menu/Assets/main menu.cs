using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
public void playGame()
    {
        SceneManager.LoadScene("level 1");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
