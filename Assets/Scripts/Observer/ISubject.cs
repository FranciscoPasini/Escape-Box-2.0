using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(string eventMessage);
}
