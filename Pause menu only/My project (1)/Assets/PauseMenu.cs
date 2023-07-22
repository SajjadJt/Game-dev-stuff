using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        // Game can be paused through the pause UI or by the Esc button on keyboard
        //Press Esc button to pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                //Call function Resume if game is already paused
                Resume();
            }
            else
            {
                //Call function Pause when the player presses Esc button
                Pause();
            }
        }
    }
    public void Resume()
    {
        //Resume the game
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        //Pause the game
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        //Load Main Menu if "Main Menu" is selected
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        //Exit the application if "Quit" is selected
        Application.Quit();
    }
}
