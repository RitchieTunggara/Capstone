using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCombiner : MonoBehaviour
{
    public Recipe[] recipes;

    public static ItemCombiner instance;
    public Item lastItem;
    public GameObject savePannel;

    private void Awake()
    {
        // if (instance == null)
        // {
            instance = this;
        //     DontDestroyOnLoad(gameObject);
        // }
        // else
        // {
        //     Destroy(gameObject);
        // }
    }

    public bool Combine(ItemHolder item1, ItemHolder item2)
    {
        foreach (Recipe recipe in recipes)
        {
            
            if ((recipe.ingredient1 == item1.item && recipe.ingredient2 == item2.item)
            || (recipe.ingredient1 == item2.item && recipe.ingredient2 == item1.item))
            {
                Debug.Log("Combining " + item1.item.Name + " and " + item2.item.Name + " to " + recipe.result.Name);
                item2.item = recipe.result;
                item2.gameObject.name = recipe.result.Name;
                item2.UpdateSprite();
               
                if (recipe.result.finalObject)
                {
                    StartCoroutine(delaySave());
                   
                }
                
                return true;
            }
        }
        Debug.Log("No recipe found for " + item1.item.Name + " and " + item2.item.Name);
        return false;
    }

    private IEnumerator delaySave()
    {
        yield return new WaitForSeconds(0.5f);
        savePannel.SetActive(true);
        
    }
   
}
