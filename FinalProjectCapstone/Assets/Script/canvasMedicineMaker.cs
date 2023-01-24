using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasMedicineMaker : MonoBehaviour
{
    queueTimerScript QueueTimerScript;
    curedPatient CuredPatient;
    playerMovement PlayerMovement;
    float xPosPlayer;
    float zPosPlayer;
    // Start is called before the first frame update
    private void Awake()
    {
        SaveLoad.Load();
    }
    void Start()
    {
        PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        // CuredPatient = GameObject.FindGameObjectWithTag("bed").GetComponent<curedPatient>();
        QueueTimerScript = GameObject.FindGameObjectWithTag("queueTimer").GetComponent<queueTimerScript>();
        xPosPlayer = PlayerMovement.xPosition;
        zPosPlayer = PlayerMovement.zPosition;
    }

    // Update is called once per frame
    void Update()
    {
        CuredPatient = GameObject.FindGameObjectWithTag("bed").GetComponent<curedPatient>();
    }

    public void jamuTemulawak()
    {
        SceneManager.LoadScene("JamuTemulawak");
        SaveLoad.data.xPosPLayer = xPosPlayer;
        SaveLoad.data.zPosPLayer = zPosPlayer;
        SaveLoad.data.OnBack = true;
        SaveLoad.data.queueTimeLeft = QueueTimerScript.timeLeft;
        SaveLoad.data.maxTimeQueue = QueueTimerScript.maxTime;
        SaveLoad.data.CountLife = QueueTimerScript.counter;
        SaveLoad.data.medicineName = "jamu temulawak";
        SaveLoad.data.trueMed = false;
        SaveLoad.Save();
        if (CuredPatient.ctr == 0)
        {
            SaveLoad.data.lastNpc = "npcKulitKusam";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 1)
        {
            SaveLoad.data.lastNpc = "npcDiare";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 2)
        {
            SaveLoad.data.lastNpc = "npcMasukAngin";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 3)
        {
            SaveLoad.data.lastNpc = "npcPegal";
            SaveLoad.Save();
        }
    }

    public void kunyitAsam()
    {
        SceneManager.LoadScene("KunyitAsam");
        SaveLoad.data.xPosPLayer = xPosPlayer;
        SaveLoad.data.zPosPLayer = zPosPlayer;
        SaveLoad.data.OnBack = true;
        SaveLoad.data.queueTimeLeft = QueueTimerScript.timeLeft;
        SaveLoad.data.maxTimeQueue = QueueTimerScript.maxTime;
        SaveLoad.data.CountLife = QueueTimerScript.counter;
        SaveLoad.data.medicineName = "kunyit asam";
        SaveLoad.data.trueMed = false;
        SaveLoad.Save();
        if (CuredPatient.ctr == 0)
        {
            SaveLoad.data.lastNpc = "npcKulitKusam";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 1)
        {
            SaveLoad.data.lastNpc = "npcDiare";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 2)
        {
            SaveLoad.data.lastNpc = "npcMasukAngin";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 3)
        {
            SaveLoad.data.lastNpc = "npcPegal";
            SaveLoad.Save();
        }
    }

    public void JamuBerasKencur()
    {
        SceneManager.LoadScene("JamuBerasKencur");
        SaveLoad.data.xPosPLayer = xPosPlayer;
        SaveLoad.data.zPosPLayer = zPosPlayer;
        SaveLoad.data.OnBack = true;
        SaveLoad.data.queueTimeLeft = QueueTimerScript.timeLeft;
        SaveLoad.data.maxTimeQueue = QueueTimerScript.maxTime;
        SaveLoad.data.CountLife = QueueTimerScript.counter;
        SaveLoad.data.medicineName = "jamu beras kencur";
        SaveLoad.data.trueMed = false;
        SaveLoad.Save();
        if (CuredPatient.ctr == 0)
        {
            SaveLoad.data.lastNpc = "npcKulitKusam";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 1)
        {
            SaveLoad.data.lastNpc = "npcDiare";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 2)
        {
            SaveLoad.data.lastNpc = "npcMasukAngin";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 3)
        {
            SaveLoad.data.lastNpc = "npcPegal";
            SaveLoad.Save();
        }
    }

    public void oralitTradisional()
    {
        SceneManager.LoadScene("OralitTradisional");
        SaveLoad.data.xPosPLayer = xPosPlayer;
        SaveLoad.data.zPosPLayer = zPosPlayer;
        SaveLoad.data.OnBack = true;
        SaveLoad.data.queueTimeLeft = QueueTimerScript.timeLeft;
        SaveLoad.data.maxTimeQueue = QueueTimerScript.maxTime;
        SaveLoad.data.CountLife = QueueTimerScript.counter;
        SaveLoad.data.medicineName = "oralit tradisional";
        SaveLoad.data.trueMed = false;
        SaveLoad.Save();
        if (CuredPatient.ctr == 0)
        {
            SaveLoad.data.lastNpc = "npcKulitKusam";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 1)
        {
            SaveLoad.data.lastNpc = "npcDiare";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 2)
        {
            SaveLoad.data.lastNpc = "npcMasukAngin";
            SaveLoad.Save();
        }
        else if (CuredPatient.ctr == 3)
        {
            SaveLoad.data.lastNpc = "npcPegal";
            SaveLoad.Save();
        }
    }
}
