using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paper : MonoBehaviour
{
    wayPointFollower WayPointFollower;
    public GameObject canvasInstruction;
    public GameObject canvasKeluhan;
    public GameObject canvasGejalaDiare;
    public GameObject canvasGejalaMasukAngin;
    public GameObject canvasGejalaKulitKusam;
    public GameObject canvasGejalaPegal;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        WayPointFollower = GameObject.FindGameObjectWithTag("npc").GetComponent<wayPointFollower>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.F))
        {
            canvasInstruction.SetActive(false);
            canvasKeluhan.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            canvasInstruction.SetActive(true);
            // WayPointFollower.onTag = true;
        }
        else if (col.CompareTag("npc") && count == 0)
        {
            canvasGejalaDiare.SetActive(true);
            // canvasGejalaKulitKusam.SetActive(false);
            // canvasGejalaMasukAngin.SetActive(false);
            // canvasGejalaPegal.SetActive(false);
        }
        else if (col.CompareTag("npc") && count == 1)
        {
            canvasGejalaDiare.SetActive(false);
            canvasGejalaDiare.SetActive(true);
        }
        else if (col.CompareTag("npc") && count == 0)
        {
            canvasGejalaDiare.SetActive(true);
        }
    }

    public void tes()
    {
        Debug.Log("Tes");
    }

}
