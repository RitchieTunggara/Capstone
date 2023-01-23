using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : MonoBehaviour
{
    public GameObject medicineMakerTrigger;
    // wayPointFollower WayPointFollower;
    public GameObject canvasInstruction;
    public GameObject canvasKeluhan;
    public GameObject canvasGejalaDiare;
    public GameObject canvasGejalaMasukAngin;
    public GameObject canvasGejalaKulitKusam;
    public GameObject canvasGejalaPegal;
    // public int count = -1;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(count);
        // WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.F))
        {
            medicineMakerTrigger.SetActive(true);
            canvasInstruction.SetActive(false);
            canvasKeluhan.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            // Debug.Log(count);
            canvasInstruction.SetActive(true);
            // WayPointFollower.onTag = true;
        }
        else if (col.CompareTag("npcKulitKusam"))
        {
            canvasGejalaKulitKusam.SetActive(true);
        }
        else if (col.CompareTag("npcDiare"))
        {
            canvasGejalaKulitKusam.SetActive(false);
            canvasGejalaDiare.SetActive(true);
        }
        else if (col.CompareTag("npcMasukAngin"))
        {
            canvasGejalaDiare.SetActive(false);
            canvasGejalaMasukAngin.SetActive(true);
        }
        else if (col.CompareTag("npcPegal"))
        {
            canvasGejalaMasukAngin.SetActive(false);
            canvasGejalaPegal.SetActive(true);
        }
    }

    public void tes()
    {
        Debug.Log("Tes");
    }

}
