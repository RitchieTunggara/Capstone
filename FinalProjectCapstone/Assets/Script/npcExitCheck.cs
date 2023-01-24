using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcExitCheck : MonoBehaviour
{
    queueTimerScript QueueTimerScript;
    curedPatient CuredPatient;
    wayPointFollower WayPointFollower1;
    wayPointFollower WayPointFollower2;
    wayPointFollower WayPointFollower3;
    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject paper;
    public GameObject CanvasGameOver;
    public GameObject buttonNext;
    // Start is called before the first frame update
    void Start()
    {
        SaveLoad.Load();
        CuredPatient = GameObject.FindGameObjectWithTag("bed").GetComponent<curedPatient>();
        WayPointFollower1 = GameObject.FindGameObjectWithTag("npcDiare").GetComponent<wayPointFollower>();
        WayPointFollower2 = GameObject.FindGameObjectWithTag("npcMasukAngin").GetComponent<wayPointFollower>();
        WayPointFollower3 = GameObject.FindGameObjectWithTag("npcPegal").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("npcKulitKusam"))
        {
            CuredPatient.ctr++;
            npc1.SetActive(true);
            paper.SetActive(false);
            WayPointFollower1.speed = 6f;
            WayPointFollower1.currentWaypointIndex = 0;
            // QueueTimerScript.timeLeft = QueueTimerScript.maxTime;
        }
        else if(col.CompareTag("npcDiare"))
        {
            CuredPatient.ctr++;
            npc2.SetActive(true);
            paper.SetActive(false);
            WayPointFollower2.speed = 6f;
            WayPointFollower2.currentWaypointIndex = 0;
            // QueueTimerScript.timeLeft = QueueTimerScript.maxTime;
        }
        else if(col.CompareTag("npcMasukAngin"))
        {
            CuredPatient.ctr++;
            npc3.SetActive(true);
            paper.SetActive(false);
            WayPointFollower3.speed = 6f;
            WayPointFollower3.currentWaypointIndex = 0;
            // QueueTimerScript.timeLeft = QueueTimerScript.maxTime;
        }
        else if (col.CompareTag("npcPegal"))
        {
            Time.timeScale = 0;
            CanvasGameOver.SetActive(true);
            buttonNext.SetActive(true);
        }
        SaveLoad.data.lastNpc = "";
        SaveLoad.data.trueMed = true;
        SaveLoad.data.totalCuredPatient = CuredPatient.ctr;
        // SaveLoad.data.queueTimeLeft = SaveLoad.data.maxTimeQueue;
        SaveLoad.Save();
        QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
        QueueTimerScript.timeLeft = QueueTimerScript.maxTime;
        QueueTimerScript.timerBar.fillAmount = 100;
    }
}
