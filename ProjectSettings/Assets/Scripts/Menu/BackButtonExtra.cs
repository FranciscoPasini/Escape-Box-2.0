using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class BackButtonExtra : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("Main menu");
    }
}
