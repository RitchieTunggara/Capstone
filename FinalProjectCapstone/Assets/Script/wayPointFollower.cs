using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointFollower : MonoBehaviour
{
    public GameObject npc;
    public GameObject npcOnBed;
    Rigidbody rb;
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex;
    public float speed = 6f;
    private float zPosition;
    private float xPosition;
    public bool onTag = false;
    public bool cured = false;
    private int turnCounter;
    // Start is called before the first frame update
    void Start()
    {
        turnCounter = 0;
        rb = GetComponent<Rigidbody>();
        currentWaypointIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        zPosition = transform.position.z;
        xPosition = transform.position.x;
        Vector3 direction = new Vector3(transform.position.x, 0f, transform.position.x).normalized;
        //turn right
        if (xPosition <= -3.14f && turnCounter == 0)
        {
            turnCounter = 1;
            transform.rotation = Quaternion.Euler(-89.706f, 270f, -90.004f);
        }
        // //turn left
        // if (zPosition == 7.93f && turnCounter == 1)
        // {
        //     turnCounter = 2;
        //     transform.rotation = Quaternion.Euler(-89.706f, 180f, -90.004f);
        // }

        if (currentWaypointIndex == 0 || currentWaypointIndex == 1)
        {
            nextWayPoint();
        }
        else if (currentWaypointIndex == 2)
        {
            turnCounter = 2;
            transform.rotation = Quaternion.Euler(-89.706f, 180f, -90.004f);
            nextWayPoint();
        }
        else if (currentWaypointIndex == 4)
        {
            transform.rotation = Quaternion.Euler(-89.706f, 180f, -90.004f);
            nextWayPoint();
        }

        if (onTag == true)
        {
            currentWaypointIndex = 2;
        }

        if (cured == true && currentWaypointIndex == 3)
        {
            transform.rotation = Quaternion.Euler(-89.706f, 90f, -90.004f);
            nextWayPoint();
        }
    }

    public void nextWayPoint() 
    {
        if (currentWaypointIndex < waypoints.Length){
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
            if (transform.position == Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime) && currentWaypointIndex==0
            || transform.position == Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime) && currentWaypointIndex==3)
            {
                currentWaypointIndex++;
                Debug.Log(currentWaypointIndex);
            }
            if (transform.position == Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime) && currentWaypointIndex==2)
            {
                npc.SetActive(false);
                npcOnBed.SetActive(true);
                currentWaypointIndex++;
                onTag = false;
                Debug.Log(currentWaypointIndex);
            }
        }
    }
}
