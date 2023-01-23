using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class queueTimerScript : MonoBehaviour
{
    public GameObject buttonRetry;
    public GameObject CanvasGameOver;
    public Image timerBar;
    public GameObject[] fail;
    public float maxTime = 50f;
    public float timeLeft = 50f;
    public int counter = 0;
    // public GameObjcet timesUpText;

    // Start is called before the first frame update
    void Start()
    {
        SaveLoad.Load();
        maxTime = 50f;
        timerBar = GetComponent<Image>();
        if (SaveLoad.data.OnBack == true)
        {
            counter = SaveLoad.data.CountLife;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        } 
        else
        {
            fail[counter].SetActive(false);
            timerBar.fillAmount = 100;
            timeLeft = maxTime;
            counter++;
        }

        if (counter > 0)
        {
            for (int i=0; i<counter; i++)
            {
                fail[counter].SetActive(false);
            }
        }
        
        if (counter>=3)
        {
            Time.timeScale = 0;
            CanvasGameOver.SetActive(true);
            buttonRetry.SetActive(true);
            // SceneManager.LoadScene("SceneStage1");
            // Time.timeScale = 1;
        }
    }
}
