using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    private float XPosPLayer;
    private float ZPosPLayer;
    private bool onBack;
    private bool firstStart;
    private string LastNpc;
    private float QueueTimeLeft;
    private float MaxTimeQueue;
    private int countLife;
    // Start is called before the first frame update
    public GameData()
    {
        XPosPLayer = -5f;
        ZPosPLayer = 16f;
        onBack = false;
        firstStart = true;
        LastNpc = "";
        QueueTimeLeft = 0f;
        countLife = 0;
    }

    // Update is called once per frame
    public float xPosPLayer
    {
        get
        {
            return XPosPLayer;
        }
        set
        {
            XPosPLayer = value;
        }
    }

    public float zPosPLayer
    {
        get
        {
            return ZPosPLayer;
        }
        set
        {
            ZPosPLayer = value;
        }
    }

    public bool OnBack
    {
        get
        {
            return onBack;
        }
        set
        {
            onBack = value;
        }
    }

    public bool FirstStart
    {
        get
        {
            return firstStart;
        }
        set
        {
            firstStart = value;
        }
    }

    public string lastNpc
    {
        get
        {
            return LastNpc;
        }
        set
        {
            LastNpc = value;
        }
    }

    public float queueTimeLeft
    {
        get
        {
            return QueueTimeLeft;
        }
        set
        {
            QueueTimeLeft = value;
        }
    }

    public float maxTimeQueue
    {
        get
        {
            return MaxTimeQueue;
        }
        set
        {
            MaxTimeQueue = value;
        }
    }

    public int CountLife
    {
        get
        {
            return countLife;
        }
        set
        {
            countLife = value;
        }
    }
}
