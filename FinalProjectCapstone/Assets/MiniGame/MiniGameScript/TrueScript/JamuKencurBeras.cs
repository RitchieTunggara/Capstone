using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JamuKencurBeras : MonoBehaviour
{
    public Button pisau;
    public Button kencur;
    public Button blender;
    public Button beras;
    public Button rebusan;
    public Button saringan;
    public GameObject result1;
    public GameObject result2;
    public GameObject result3;
    public GameObject result4;
    public GameObject result5;
    public GameObject result6;
    public GameObject resultGagal;

    //result pertama atau step racik pertama
    public void Result1()
    {
        result1.SetActive(true);
    }
    // potong kencur
    public void Result2()
    {
        if (result1 == false)
        {

        }
        else if( result1 == true)
        {
            
            result1.SetActive(false);
            result2.SetActive(true);
        }
        else
        {

        }
        
    }
    //blender kencur
    public void Result3()
    {
        if (result2 == false|| result1 == false)
        {
            pisau.interactable = false;
            kencur.interactable = false;
            blender.interactable = false;
            beras.interactable = false;
            rebusan.interactable = false;
            saringan.interactable = false;
            resultGagal.SetActive(true);
        }
        else if (result2 == true ||result4==true || result5== true)
        {
            if (result1 == false)
            {
                result2.SetActive(false);
                resultGagal.SetActive(false);
                result3.SetActive(true);
            }
        }

    }
    // masukin beras atau racikan
    public void Result4()
    {
        if (result3 == false || result5== false|| result2 == false || result1 == false)
        {

            pisau.interactable = false;
            kencur.interactable = false;
            blender.interactable = false;
            beras.interactable = false;
            rebusan.interactable = false;
            saringan.interactable = false;
            result3.SetActive(false);
            resultGagal.SetActive(true);
        }
        else if (result3 == true || result5 == true)
        {
            if (result2 == false && result1 == false)
            {
                resultGagal.SetActive(false);
                result3.SetActive(false);
                result4.SetActive(true);
                result5.SetActive(false);
            }
            else
            {

            }
        }

    }
    public void Result5()
    {
        if (result3 == false || result4 == false || result2 == false || result1 == false)
        {

            pisau.interactable = false;
            kencur.interactable = false;
            blender.interactable = false;
            beras.interactable = false;
            rebusan.interactable = false;
            saringan.interactable = false;
            resultGagal.SetActive(true);
        }
        else if (result3 == true || result4 == true)
        {
            if (result2 == false && result1 == false)
            {
                resultGagal.SetActive(false);
                result3.SetActive(false);
                result4.SetActive(false);
                result5.SetActive(true);
            }
            else
            {

            }
        }

    }
    //gabungan semua
    public void Result6()
    {
        if (result4==false || result5== false|| result3 == false ||  result2 == false || result1 == false)
        {

            pisau.interactable = false;
            kencur.interactable = false;
            blender.interactable = false;
            beras.interactable = false;
            rebusan.interactable = false;
            saringan.interactable = false;
            resultGagal.SetActive(true);
        }
        else if (result5 == true || result4 == true)
        {
            if (result2 == false && result1 == false && result3 == false)
            {
                resultGagal.SetActive(false);
                result4.SetActive(false);
                result5.SetActive(false);
                result6.SetActive(true);
            }
            else
            {

            }
        }

    }

   
}
