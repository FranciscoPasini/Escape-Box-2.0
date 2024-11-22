using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allCoins : MonoBehaviour
{
    void Update()
    {
        allCoinsCollected();
    }

    public void allCoinsCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("All Coins Collected");
        }
    }
}
