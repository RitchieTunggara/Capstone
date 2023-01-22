using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curedPatient : MonoBehaviour
{
    wayPointFollower WayPointFollower;
    public GameObject npc;
    public GameObject npcOnBed;
    // Start is called before the first frame update
    void Start()
    {
        WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            Debug.Log("tes");
            npc.SetActive(true);
            npcOnBed.SetActive(false);
            WayPointFollower.cured = true;
        }
    }
}
