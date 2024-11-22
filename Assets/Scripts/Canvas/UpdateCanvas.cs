using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateCanvas : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    private void Start()
    {
        UpdateCoinDisplay();
    }

    public void UpdateCoinDisplay()
    {
        coinText.text = "Coins: " + CoinManager.Instance.Coins.ToString();
    }
}
