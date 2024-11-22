using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoManager : MonoBehaviour
{
    [SerializeField] private PlayerMemento _player;
    private Stack<Memento> _savedStates = new Stack<Memento>();


    public void SavePState()
    {
        Memento memento = _player.SaveState();
        _savedStates.Push(memento);
    }

    public void RestorePState()
    {
        if (_savedStates.Count > 0)
        {
            Memento lastState = _savedStates.Pop();
            _player.RestoreState(lastState);
        }
    }
}
