using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curedPatient : MonoBehaviour
{
    wayPointFollower WayPointFollower;
    wayPointFollower WayPointFollower2;
    wayPointFollower WayPointFollower3;
    wayPointFollower WayPointFollower4;
    public GameObject npc;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npcOnBed;
    public int ctr;
    // Start is called before the first frame update
    void Start()
    {
        ctr = 0;
        WayPointFollower = GameObject.FindGameObjectWithTag("npcKulitKusam").GetComponent<wayPointFollower>();
        WayPointFollower2 = GameObject.FindGameObjectWithTag("npcDiare").GetComponent<wayPointFollower>();
        WayPointFollower3 = GameObject.FindGameObjectWithTag("npcMasukAngin").GetComponent<wayPointFollower>();
        WayPointFollower4 = GameObject.FindGameObjectWithTag("npcPegal").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player") && ctr == 0)
        {
            // Debug.Log("tes");
            npc.SetActive(true);
            npcOnBed.SetActive(false);
            WayPointFollower.cured = true;
        }
        else if(col.CompareTag("Player") && ctr == 1)
        {
            // Debug.Log("tes");
            npc2.SetActive(true);
            npcOnBed.SetActive(false);
            WayPointFollower2.cured = true;
        }
        else if(col.CompareTag("Player") && ctr == 2)
        {
            // Debug.Log("tes");
            npc3.SetActive(true);
            npcOnBed.SetActive(false);
            WayPointFollower3.cured = true;
        }
        else if(col.CompareTag("Player") && ctr == 3)
        {
            // Debug.Log("tes");
            npc4.SetActive(true);
            npcOnBed.SetActive(false);
            WayPointFollower4.cured = true;
        }
    }
}
