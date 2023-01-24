using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    exitMini ExitMini;
    float queueTimeLeft;
    int countLife;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SaveLoad.Load();
        ExitMini = GameObject.FindGameObjectWithTag("exitMini").GetComponent<exitMini>();
        queueTimeLeft = ExitMini.queueTimeLeft;
        countLife = ExitMini.countLife;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void update()
    {
        if (queueTimeLeft > 0)
        {
            queueTimeLeft -= Time.deltaTime;
        } 
        else 
        {
            queueTimeLeft = SaveLoad.data.maxTimeQueue;
            countLife++;
        }
    }

    public void saveData(Item item1)
    {
        PlayerPrefs.SetInt("saveItem", (item1.finalObject ? 1 : 0));
        Debug.Log("item Saved");

        SaveLoad.data.queueTimeLeft = queueTimeLeft;
        SaveLoad.data.CountLife = countLife;
        SaveLoad.data.exitMini = false;
        SaveLoad.Save();
        SceneManager.LoadScene("SceneStage1");
    }
    // panggil save nya di scipt ganti scene
    // panggil dlu script itemnya / result
    // lalu masukin kode yang di bawah ini
    // PlayerPrefs.GetInt("saveItem") !=0;

}
