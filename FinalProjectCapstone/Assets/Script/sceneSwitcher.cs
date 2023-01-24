using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    void Awake()
    {
        SaveLoad.Load();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
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
    }

    public void exitGame()
    {
        SaveLoad.data.lastNpc = "";
        SaveLoad.data.FirstStart = true;
        SaveLoad.data.CountLife = 0;
        SaveLoad.data.queueTimeLeft = SaveLoad.data.maxTimeQueue;
        SaveLoad.data.exitMini = false;
        SaveLoad.data.trueMed = true;
        SaveLoad.data.totalCuredPatient = 0;
        SaveLoad.Save();
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
