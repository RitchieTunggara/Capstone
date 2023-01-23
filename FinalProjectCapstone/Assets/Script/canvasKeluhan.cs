using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasKeluhan : MonoBehaviour
{
    wayPointFollower WayPointFollower;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        // WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
    //    WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    public void letNpcToBed()
    {
        if (counter == 0)
        {
            WayPointFollower = GameObject.FindGameObjectWithTag("npcKulitKusam").GetComponent<wayPointFollower>();
            WayPointFollower.onTag = true;
            counter++;
        }
        else if (counter == 1)
        {
            WayPointFollower = GameObject.FindGameObjectWithTag("npcDiare").GetComponent<wayPointFollower>();
            WayPointFollower.onTag = true;
            counter++;
        }
        else if (counter == 2)
        {
            WayPointFollower = GameObject.FindGameObjectWithTag("npcMasukAngin").GetComponent<wayPointFollower>();
            WayPointFollower.onTag = true;
            counter++;
        }
        else if (counter == 3)
        {
            WayPointFollower = GameObject.FindGameObjectWithTag("npcPegal").GetComponent<wayPointFollower>();
            WayPointFollower.onTag = true;
            counter++;
        }
        // Debug.Log("tes");
        // WayPointFollower.onTag = true;
    }
}
