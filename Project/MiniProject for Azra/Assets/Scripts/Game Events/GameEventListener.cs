using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] UnityEvent _unityEvent;
    [SerializeField] GameEvent _gameEvent;

    void Awake()
    {
        _gameEvent.Register(this);
    }
    private void OnDisable()
    {
        _gameEvent.Deregister(this);
    }
    public void RaiseEvent()
    {
        _unityEvent.Invoke();
    }
}
