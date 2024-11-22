using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOBS : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    [SerializeField] private MementoManager mementoManager;

    private void Start()
    {
        mementoManager.SavePState();
    }

    public void RegisterObserver(IObserver observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers(string eventMessage)
    {
        foreach (IObserver observer in observers)
        {
            observer.OnNotify(eventMessage);
        }
    }

    public void Die()
    {
        mementoManager.RestorePState();
        NotifyObservers("Player Respawned");
        mementoManager.SavePState();
    }

    public void CollectCoin()
    {
        CoinManager.Instance.AddCoin();
        NotifyObservers("CoinCollected");
    }
}
