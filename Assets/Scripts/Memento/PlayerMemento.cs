using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMemento : MonoBehaviour
{
    private Vector3 _lastSavedPosition;

    public Memento SaveState()
    {
        _lastSavedPosition = transform.position;

        return new Memento(_lastSavedPosition);
    }

    public void RestoreState(Memento memento)
    {
        transform.position = memento.position;
    }
}
