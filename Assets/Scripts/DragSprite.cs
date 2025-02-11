using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragSprite : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Inicio del arrastre");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition; // Sigue el mouse
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Fin del arrastre");
    }
}
