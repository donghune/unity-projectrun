using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject highScoreUI;
    public GameObject totalCoinUI;
    void Update()
    {       
        DataManager.dataManager.highScore = Mathf.Max(DataManager.dataManager.highScore, DataManager.dataManager.currentScore);
        scoreUI.GetComponent<Text>().text = ("Score " + DataManager.dataManager.currentScore.ToString());
        highScoreUI.GetComponent<Text>().text = ("High Score " + DataManager.dataManager.highScore.ToString());
        totalCoinUI.GetComponent<Text>().text = ("total Coins " + DataManager.dataManager.totalCoins.ToString());
    }
}
