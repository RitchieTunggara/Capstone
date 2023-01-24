using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPatientAfterMini : MonoBehaviour
{
    public GameObject npcKulitKusam;
    public GameObject npcDiare;
    public GameObject npcMasukAngin;
    public GameObject npcPegal;
    public GameObject canvasQueue;
    public GameObject npcOnBed;
    public GameObject medicineTrigger;
    wayPointFollower WayPointFollower0;
    wayPointFollower WayPointFollower1;
    wayPointFollower WayPointFollower2;
    wayPointFollower WayPointFollower3;
    queueTimerScript QueueTimerScript;
    // Start is called before the first frame update
    void Start()
    {
        WayPointFollower0 = GameObject.FindGameObjectWithTag("npcKulitKusam").GetComponent<wayPointFollower>();
        WayPointFollower1 = GameObject.FindGameObjectWithTag("npcDiare").GetComponent<wayPointFollower>();
        WayPointFollower2 = GameObject.FindGameObjectWithTag("npcMasukAngin").GetComponent<wayPointFollower>();
        WayPointFollower3 = GameObject.FindGameObjectWithTag("npcPegal").GetComponent<wayPointFollower>();
        
        SaveLoad.Load();
        SaveLoad.data.FirstStart = false;
        SaveLoad.Save();

        if (SaveLoad.data.lastNpc.Equals("npcKulitKusam") && SaveLoad.data.exitMini == false 
                && SaveLoad.data.medicineName.Equals("kunyit asam"))
        {
            npcKulitKusam.transform.position = new Vector3(-22.07f, 1f, 7.93f);
            WayPointFollower0.currentWaypointIndex = 3;
            // Debug.Log(WayPointFollower0.currentWaypointIndex);
            WayPointFollower0.cured = true;
            WayPointFollower0.speed = 6f;
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            // Debug.Log(SaveLoad.data.queueTimeLeft);
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
            // QueueTimerScript.counter = SaveLoad.data.CountLife;
            SaveLoad.data.trueMed = true;
            SaveLoad.Save();
        }
        else if (SaveLoad.data.lastNpc.Equals("npcDiare") && SaveLoad.data.exitMini == false 
                && SaveLoad.data.medicineName.Equals("oralit tradisional"))
        {
            npcDiare.transform.position = new Vector3(-22.07f, 1f, 7.93f);
            WayPointFollower1.currentWaypointIndex = 3;
            // Debug.Log(WayPointFollower0.currentWaypointIndex);
            WayPointFollower1.cured = true;
            WayPointFollower1.speed = 6f;
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            // Debug.Log(SaveLoad.data.queueTimeLeft);
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
            // QueueTimerScript.counter = SaveLoad.data.CountLife;
            SaveLoad.data.trueMed = true;
            SaveLoad.Save();
        }
        else if (SaveLoad.data.lastNpc.Equals("npcMasukAngin") && SaveLoad.data.exitMini == false 
                && SaveLoad.data.medicineName.Equals("jamu temulawak"))
        {
            npcMasukAngin.transform.position = new Vector3(-22.07f, 1f, 7.93f);
            WayPointFollower2.currentWaypointIndex = 3;
            // Debug.Log(WayPointFollower0.currentWaypointIndex);
            WayPointFollower2.cured = true;
            WayPointFollower2.speed = 6f;
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            // Debug.Log(SaveLoad.data.queueTimeLeft);
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
            // QueueTimerScript.counter = SaveLoad.data.CountLife;
            SaveLoad.data.trueMed = true;
            SaveLoad.Save();
        }
        else if (SaveLoad.data.lastNpc.Equals("npcPegal") && SaveLoad.data.exitMini == false 
                && SaveLoad.data.medicineName.Equals("jamu beras kencur"))
        {
            npcPegal.transform.position = new Vector3(-22.07f, 1f, 7.93f);
            WayPointFollower3.currentWaypointIndex = 3;
            // Debug.Log(WayPointFollower0.currentWaypointIndex);
            WayPointFollower3.cured = true;
            WayPointFollower3.speed = 6f;
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            // Debug.Log(SaveLoad.data.queueTimeLeft);
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
            // QueueTimerScript.counter = SaveLoad.data.CountLife;
            SaveLoad.data.trueMed = true;
            SaveLoad.Save();
        }
        else if (SaveLoad.data.exitMini == true || SaveLoad.data.trueMed == false)
        {
            Debug.Log(SaveLoad.data.lastNpc + " " + SaveLoad.data.medicineName);
            Debug.Log(SaveLoad.data.exitMini + " " + SaveLoad.data.trueMed);
            npcOnBed.SetActive(true);
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
            medicineTrigger.SetActive(true);
            SaveLoad.data.trueMed = true;
            SaveLoad.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
