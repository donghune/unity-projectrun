using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager dataManager;

    public int currentScore;
    public int highScore;
    public int totalCoins;

    private void Awake()
    {
        if(dataManager == null)
        {
            DontDestroyOnLoad(gameObject);
            dataManager = this;
        }
        else if(dataManager != this)
        {
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
        gameData data = new gameData();
        data.highScore = highScore;
        data.totalCoins = totalCoins;
        binaryFormatter.Serialize(file, data);
        file.Close();
    }

    public void LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
            gameData gameData = (gameData)binaryFormatter.Deserialize(file);
            file.Close();
            highScore = gameData.highScore;
            totalCoins = gameData.totalCoins;
            Debug.Log("LoadData loadde");
        }
    }
}

[Serializable]
class gameData
{
    public int highScore;
    public int totalCoins;
}
