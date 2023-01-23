using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupboard : MonoBehaviour
{
    public GameObject canvasIntrusction;
    public GameObject canvasMedicineMaker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Q))
        {
            canvasIntrusction.SetActive(false);
            canvasMedicineMaker.SetActive(true);
        }
    }

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            canvasIntrusction.SetActive(true);
        }

        // if(col.CompareTag("Player") && Input.GetKey (KeyCode.Q))
        // {
        //     canvasIntrusction.SetActive(false);
        //     canvasMedicineMaker.SetActive(true);
        // }
    }

}
