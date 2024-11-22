using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour, IObserver
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private TMP_Text coinText;

    private PlayerOBS playerOBS;

    private void Start()
    {
        RegisterPlayer();
        UpdateCoinDisplay();
    }

    private void RegisterPlayer()
    {
        playerOBS = FindObjectOfType<PlayerOBS>();
        if (playerOBS != null)
        {
            playerOBS.RegisterObserver(this);
            UpdateCoinDisplay();
        }
    }

    public void OnNotify(string eventMessage)
    {
        UpdateCoinDisplay();
    }

    public void UpdateCoinDisplay()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + CoinManager.Instance.Coins;
        }
    }

    private void OnDestroy()
    {
        if (playerOBS != null)
        {
            playerOBS.RemoveObserver(this);
        }
    }
}
