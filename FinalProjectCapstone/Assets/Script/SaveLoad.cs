using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad
{
    public static GameData data = new GameData();

    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Create(Application.persistentDataPath + "/finalCapstone.bk");
        bf.Serialize(fs, data);
        fs.Close();
    }

    public static void Load()
    {
       if (File.Exists(Application.persistentDataPath + "/finalCapstone.bk"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Application.persistentDataPath + "/finalCapstone.bk",FileMode.Open);
            data = (GameData)bf.Deserialize(fs);
            fs.Close();
        }
        else
        {
            Save();
            Load();
        }
    }
}