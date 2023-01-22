using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasKeluhan : MonoBehaviour
{
    wayPointFollower WayPointFollower;
    // Start is called before the first frame update
    void Start()
    {
        WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void letNpcToBed()
    {
        // Debug.Log("tes");
        WayPointFollower.onTag = true;
    }
}
