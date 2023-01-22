using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class jamuBerasKencur : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    static public GameObject itemBeingDragged;
    static public buttonObj tmpButton;
    public void OnBeginDrag(PointerEventData eventData)
    {
        GameObject duplicate = Instantiate(gameObject);
        itemBeingDragged = duplicate;
        RectTransform tmpRT = gameObject.GetComponent<RectTransform>();
        RectTransform rt = itemBeingDragged.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(tmpRT.sizeDelta.x, tmpRT.sizeDelta.y);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
        tmpButton = GetComponent<buttonObj>();
        Transform canvas = GameObject.FindGameObjectWithTag("UI Canvas").transform;
        itemBeingDragged.transform.SetParent(canvas);
        itemBeingDragged.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        itemBeingDragged.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Destroy(jamuBerasKencur.itemBeingDragged);
        jamuBerasKencur.itemBeingDragged = null;
        
    }
}
