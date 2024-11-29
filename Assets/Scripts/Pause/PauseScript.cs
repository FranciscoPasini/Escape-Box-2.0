using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool Pause = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause == false)
            {
                PauseMenu.SetActive(true);
                Pause = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (Pause == true)
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Pause = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    public void RestartLevel()
    {
        PauseMenu.SetActive(false);
        Pause = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main menu");
        Time.timeScale = 1;
    }
}