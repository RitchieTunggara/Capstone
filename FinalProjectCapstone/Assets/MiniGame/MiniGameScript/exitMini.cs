using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitMini : MonoBehaviour
{
    public float queueTimeLeft;
    public int countLife;
    public void Start()
    {
        SaveLoad.Load();
        queueTimeLeft = SaveLoad.data.queueTimeLeft;
        countLife = SaveLoad.data.CountLife;
    }
    public void Update()
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
    public void exitScene()
    {
        SaveLoad.data.queueTimeLeft = queueTimeLeft;
        SaveLoad.data.CountLife = countLife;
        SaveLoad.data.exitMini = true;
        SaveLoad.Save();
        SceneManager.LoadScene("SceneStage1");
    }
}
