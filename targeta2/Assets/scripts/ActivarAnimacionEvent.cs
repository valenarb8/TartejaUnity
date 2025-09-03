using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivarAnimacionEvent : MonoBehaviour
{
    public UnityEvent myEvent;

    private void OnMouseDown()
    {
        myEvent.Invoke();
    }
}
