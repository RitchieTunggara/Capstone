using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dropItem : MonoBehaviour, IDropHandler
{
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        buttonObj myButton = gameObject.GetComponent<buttonObj>();
        buttonObj dropButton = jamuBerasKencur.itemBeingDragged.GetComponent<buttonObj>();
        Image dropSprite = jamuBerasKencur.itemBeingDragged.GetComponent<Image>();
        gameObject.GetComponent<Button>().image.sprite = dropSprite.sprite;

        myButton.ItemID = dropButton.ItemID;
        myButton.ItemName = dropButton.ItemName;
        myButton.SpriteID = dropButton.SpriteID;


        Destroy(jamuBerasKencur.itemBeingDragged);
        jamuBerasKencur.itemBeingDragged = null;
    }

}
