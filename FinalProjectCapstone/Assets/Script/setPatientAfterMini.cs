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

        if (SaveLoad.data.lastNpc.Equals("npcKulitKusam"))
        {
            npcKulitKusam.transform.position = new Vector3(-22.07f, 1f, 7.93f);
            WayPointFollower0.currentWaypointIndex = 3;
            Debug.Log(WayPointFollower0.currentWaypointIndex);
            WayPointFollower0.cured = true;
            WayPointFollower0.speed = 6f;
            canvasQueue.SetActive(true);
            QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
            Debug.Log(SaveLoad.data.queueTimeLeft);
            QueueTimerScript.timeLeft = SaveLoad.data.queueTimeLeft;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
