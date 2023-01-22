using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPaper : MonoBehaviour
{
    public GameObject paperComplaints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("npc"))
        {
            paperComplaints.SetActive(true);
        }
    }
}
