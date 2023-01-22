using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NextBackButton : MonoBehaviour
{
    public Button buttonNext;
    public Button buttonBack;
    public GameObject nextButton;
    public GameObject BackButton;
    public GameObject page1;
    public GameObject page2;
   
    //atur panel 1
     public void PanelPage1()
    {
        BackButton.SetActive(false);
        page2.SetActive(false);
        nextButton.SetActive(true);
        page1.SetActive(true);
    }
    //atur panel 2
    public void PanelPage2()
    {
        
            BackButton.SetActive(true);
            page2.SetActive(true);
            nextButton.SetActive(false);
            page1.SetActive(false);
        
    }
}
