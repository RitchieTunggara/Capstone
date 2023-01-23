using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasMedicineMaker : MonoBehaviour
{
    queueTimerScript QueueTimerScript;
    curedPatient CuredPatient;
    playerMovement PlayerMovement;
    float xPosPlayer;
    float zPosPlayer;
    // Start is called before the first frame update
    private void Awake()
    {
        SaveLoad.Load();
    }
    void Start()
    {
        PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        CuredPatient = GameObject.FindGameObjectWithTag("bed").GetComponent<curedPatient>();
        QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
        xPosPlayer = PlayerMovement.xPosition;
        zPosPlayer = PlayerMovement.zPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jamuTemulawak()
    {
        SceneManager.LoadScene("JamuTemulawak");
        SaveLoad.data.xPosPLayer = xPosPlayer;
        SaveLoad.data.zPosPLayer = zPosPlayer;
        SaveLoad.data.OnBack = true;
        SaveLoad.data.queueTimeLeft = QueueTimerScript.timeLeft;
        SaveLoad.data.maxTimeQueue = QueueTimerScript.maxTime;
        SaveLoad.data.CountLife = QueueTimerScript.counter;
        SaveLoad.Save();
        Debug.Log(SaveLoad.data.queueTimeLeft);
        if (CuredPatient.ctr == 0)
        {
            SaveLoad.data.lastNpc = "npcKulitKusam";
            SaveLoad.Save();
        }
    }
}
