using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SavingData 
{
    
    public static void SaveScore(ScoreScript score,PlayerScript playerScript, Bigboss bigboss,PoopPoolScript poopPoolScript,Life life, float poopTimer) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = @"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop";/* Application.persistentDataPath + "player.pop";*/
        FileStream stream = new FileStream(path, FileMode.Create);
        Data data = new Data(score, playerScript, bigboss, poopPoolScript, life, poopTimer);
        formatter.Serialize(stream, data);
        stream.Close(); 
    }
    public static Data LoadData() 
    {
        string path = @"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop";/* Application.persistentDataPath + "player.pop";*/
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data data =  formatter.Deserialize(stream) as Data;
            stream.Close();
            return data;
        }
        else 
        {
            Debug.LogError("Can not found file in path "+ path);
            return null;
        }


    }
}
