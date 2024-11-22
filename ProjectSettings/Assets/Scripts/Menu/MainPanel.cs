using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volume;
    public AudioMixer mixer;
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject playPanel;

    private void Awake()
    {
        volume.onValueChanged.AddListener(ChangeVolume);
    }

    public void OpenPanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);
        playPanel.SetActive(false);

        panel.SetActive(true);
    }

    public void ChangeVolume(float v)
    {
        mixer.SetFloat("Volume", v);
    }

    public void PlayLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void LevelCreator()
    {
        SceneManager.LoadScene("Level Creator");
    }
    public void Inventory()
    {
        SceneManager.LoadScene("Inventory");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}