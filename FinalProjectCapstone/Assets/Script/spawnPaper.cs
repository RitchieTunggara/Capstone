using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPaper : MonoBehaviour
{
    public GameObject SetPatientAfterMini;
    public GameObject paperComplaints;
    public GameObject CanvasQueue;
    // Start is called before the first frame update
    void Start()
    {
        SaveLoad.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("npcKulitKusam") || other.CompareTag("npcDiare") || other.CompareTag("npcMasukAngin") || other.CompareTag("npcPegal"))
        {
            paperComplaints.SetActive(true);
            CanvasQueue.SetActive(true);
            SaveLoad.data.FirstStart = false;
            SaveLoad.Save();
            // Debug.Log(SaveLoad.data.FirstStart);
            SetPatientAfterMini.SetActive(true);
        }
    }
}
