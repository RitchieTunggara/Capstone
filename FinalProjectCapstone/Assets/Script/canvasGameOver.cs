using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveLoad.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        SaveLoad.data.lastNpc = "";
        SaveLoad.data.FirstStart = true;
        SaveLoad.data.CountLife = 0;
        SaveLoad.data.queueTimeLeft = SaveLoad.data.maxTimeQueue;
        SaveLoad.data.exitMini = false;
        SaveLoad.data.trueMed = true;
        SaveLoad.data.totalCuredPatient = 0;
        SaveLoad.Save();
        SceneManager.LoadScene("SceneStage1");
        Time.timeScale = 1;
        // SaveLoad.data.FirstStart = true;
        // SaveLoad.Save();
    }

    public void exit()
    {
        SaveLoad.data.lastNpc = "";
        SaveLoad.data.FirstStart = true;
        SaveLoad.data.CountLife = 0;
        SaveLoad.data.queueTimeLeft = SaveLoad.data.maxTimeQueue;
        SaveLoad.data.exitMini = false;
        SaveLoad.data.trueMed = true;
        SaveLoad.data.totalCuredPatient = 0;
        SaveLoad.Save();
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        // SaveLoad.data.FirstStart = true;
        // SaveLoad.Save();
    }
}
