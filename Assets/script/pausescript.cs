using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausescript : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
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
    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1F;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0F;
        GameIsPaused = true;

    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}