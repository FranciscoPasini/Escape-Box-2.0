using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasINT : MonoBehaviour
{
    private void Start()
    {
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            Canvas canvas = GetComponent<Canvas>();
            if (canvas != null)
            {
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = mainCamera;
            }
        }
        else
        {
            Debug.LogWarning("No se encontró la Main Camera en la escena.");
        }
    }
}
