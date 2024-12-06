using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource fxSource;
    public Slider musicSlider;
    public Slider fxSlider;

    private void Awake()
    {
        if (FindObjectsOfType<VolumeScript>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        if (musicSlider == null)
        {
            musicSlider = GameObject.Find("MusicSlider")?.GetComponent<Slider>();
        }
        if (fxSlider == null)
        {
            fxSlider = GameObject.Find("FXSlider")?.GetComponent<Slider>();
        }

        float savedMusicVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        float savedFXVolume = PlayerPrefs.GetFloat("FXVolume", 0.5f);

        musicSource.volume = savedMusicVolume;
        fxSource.volume = savedFXVolume;

        if (musicSlider != null)
        {
            musicSlider.value = savedMusicVolume;
        }
        if (fxSlider != null)
        {
            fxSlider.value = savedFXVolume;
        }
    }

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = Mathf.Clamp(volume, 0f, 1f);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void SetFXVolume(float volume)
    {
        fxSource.volume = Mathf.Clamp(volume, 0f, 1f);
        PlayerPrefs.SetFloat("FXVolume", volume);
    }
}