using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerButtons : MonoBehaviour
{
    [SerializeField] private GameObject playCanvas;
    [SerializeField] private GameObject pauseCanvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Options();
        }
    }

    //LevelSelector Button
    public void Play()
    {
        playCanvas.SetActive(true);
    }

    //MainMenu Button
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //Options Button
    public void Options()
    {
        pauseCanvas.SetActive(true);
    }

    //Exit Button
    public void Exit()
    {
        Application.Quit();
    }

    //L1 Button
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    //L2 Button
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    //L3 Button
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    //L4 Button
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }

    //Credits Button
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    //Back To Menu (From Play Panel)
    public void BackPlay()
    {
        playCanvas.SetActive(false);
    }

    //Back To Menu (From Pause Panel)
    public void BackPause()
    {
        pauseCanvas.SetActive(false);
    }
}
