using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonPress : MonoBehaviour
{
    
   public  GameObject result;
    public Button disableBut;

    public void OnAndOff()
    {
        if (!result.activeInHierarchy)
        {
            result.SetActive(true);
            disableBut.interactable = false;
        }
        else
        {
            result.SetActive(false);
            disableBut.interactable = true;
        }
    }
}
