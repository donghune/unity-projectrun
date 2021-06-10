using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    public static bool gameIsPlaying;
    void Start()
    {
        gameIsPlaying = true;
        DataManager.dataManager.currentScore = 0;
        DataManager.dataManager.LoadData();
        Debug.Log("DataManagerloadde");
    }
}
