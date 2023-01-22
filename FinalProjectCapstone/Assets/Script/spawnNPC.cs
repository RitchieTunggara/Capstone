using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNPC : MonoBehaviour
{
    private int count;
    [SerializeField] GameObject[] NpcGO;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count==0)
        {
            SpawnNpc(0);
            count++;
        }
    }

    public void SpawnNpc(int queue)
    {
        GameObject npc = (GameObject) Instantiate (NpcGO[queue]);
    }
}
