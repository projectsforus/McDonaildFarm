using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class save {


    public static void SavePlayer(player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath +"/player.data";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(player);
        formatter.Serialize(stream, data);

        stream.Close();
    }
	
    public static playerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();
             return data;

        }
        else
        {
            Debug.LogError("save file not  found in" + path);
            return null;
        }
    }

}
