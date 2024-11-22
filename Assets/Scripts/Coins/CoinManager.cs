using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }
    public int Coins { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        Coins++;
    }

    public void ResetCoins()
    {
        Coins = 0;
    }
}
