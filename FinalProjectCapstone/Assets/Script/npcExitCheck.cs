using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcExitCheck : MonoBehaviour
{
    paper Paper;
    public GameObject paper;
    // Start is called before the first frame update
    void Start()
    {
        Paper = GameObject.FindGameObjectWithTag("paper").GetComponent<paper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("npc"))
        {
            Paper.count++;
            paper.SetActive(false);
        }
    }
}
