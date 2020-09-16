using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector] private bool pressed;

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = false;
    }
}
