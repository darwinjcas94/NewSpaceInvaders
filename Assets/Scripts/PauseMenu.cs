using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // variable to track if the game is paused or not
    public static bool GameIsPaused = false;

    //to acces the pause menu UI
    public GameObject pauseMenuUI;


    // Update is called once per frame
    //Esc key to pause
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Used for slow motion effects, 0 makes it freeze
        GameIsPaused = true;
    }

    public void Resume() //make it public, so can trigger it from the button
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}