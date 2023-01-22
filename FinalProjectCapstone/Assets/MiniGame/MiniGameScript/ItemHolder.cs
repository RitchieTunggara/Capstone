using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public Item item;
    public float combineRadius = 0.5f;
    private Vector3 originalPosition;

    private void Start()
    {
        UpdateSprite();
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 1;
        originalPosition = transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    // Check if an item overlaps with another item on mouse up
    private void OnMouseUp()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, combineRadius);
        bool overLappingWithDropZone = false;
        bool overLappingWithOtherItem = false;
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.tag == "DropZone")
            {
                overLappingWithDropZone = true;
            }
            if (collider.GetComponent<ItemHolder>() != null && collider.gameObject != gameObject)
            {
                overLappingWithOtherItem = true;
            }
        }
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject != gameObject)
            {

                ItemHolder itemHolder = collider.GetComponent<ItemHolder>();
                if (itemHolder != null && overLappingWithDropZone && overLappingWithOtherItem)
                {
                    bool result = ItemCombiner.instance.Combine(this, itemHolder);
                    if (result)
                    {
                        Destroy(gameObject);
                    }
                   
                }
                

                // If the other gameobject has tag "DropZone", place it there. Otherwise, place it back to its original position
                if (collider.gameObject.tag == "DropZone" && !overLappingWithOtherItem && overLappingWithDropZone)
                {
                    transform.position = collider.transform.position;
                    break;
                }
                else
                {
                    transform.position = originalPosition;
                }
            }
            
        }
        if (colliders.Length == 1)
            transform.position = originalPosition;
        
    }

    // Gets called when the item is created
    public void UpdateSprite()
    {
        GetComponent<SpriteRenderer>().sprite = item.Sprite;
    }

}
