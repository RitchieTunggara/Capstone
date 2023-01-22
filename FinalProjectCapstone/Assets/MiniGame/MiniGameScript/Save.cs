using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void saveData(Item item1)
    {
        PlayerPrefs.SetInt("saveItem", (item1.finalObject ? 1 : 0));
        Debug.Log("item Saved");
    }
    // panggil save nya di scipt ganti scene
    // panggil dlu script itemnya / result
    // lalu masukin kode yang di bawah ini
    // PlayerPrefs.GetInt("saveItem") !=0;

}
