using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] coins;
    public GameObject[] trees;
    public GameObject player;
    public GameObject enemy;

    private float coinSpawnTimer = 7.0f;
    private float enemySpawnTimer = 10.0f;
    private float treeSpawnTimer = 0.5f;
    
    private Vector3 treeXSpawnStartLocations;
    private float treeStartSpawnTimes=20;
    void Start()
    {
        treeXSpawnStartLocations.x = -30;
        SpawnStartTrees();
    }
    void Update()
    {
        coinSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
        treeSpawnTimer -= Time.deltaTime;

        if(coinSpawnTimer < 0.01 && GameInit.gameIsPlaying)
        {
            SpawnCoins();
        }

        if (enemySpawnTimer < 0.01 && GameInit.gameIsPlaying)
        {
            SpawnEnemies();
        }

        if (treeSpawnTimer < 0.01 && GameInit.gameIsPlaying)
        {
            SpawnTrees();
        }
    }

    void SpawnStartTrees()
    {
        while (treeStartSpawnTimes>0)
        {
            GameObject startTreeGameObject = Instantiate(trees[(Random.Range(0, trees.Length))],
                new Vector3(treeXSpawnStartLocations.x, 0, Random.Range(5, 25)), Quaternion.Euler(0,Random.Range(0,360),0));
            startTreeGameObject.transform.localScale = new Vector3(Random.Range(0.9f, 1.5f),Random.Range(0.9f, 1.5f),Random.Range(0.9f, 1.5f));
            treeXSpawnStartLocations.x = treeXSpawnStartLocations.x + 5;
            treeStartSpawnTimes--;
        }
    }
    
    void SpawnCoins()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))],
            new Vector3(player.transform.position.x + 20, Random.Range(1, 5), 0), Quaternion.identity);
        coinSpawnTimer = Random.Range(1.0f, 3.0f);
    }

    void SpawnEnemies()
    {
        enemy.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
        Instantiate(enemy, new Vector3(player.transform.position.x + 25, Random.Range(1, 5), 0), Quaternion.identity);
        enemySpawnTimer = Random.Range(1, 3);
    }

    void SpawnTrees()
    {
        GameObject spawnTreeGameObject = Instantiate(trees[(Random.Range(0, trees.Length))], new Vector3(player.transform.position.x + 10, 0, Random.Range(5, 25)), Quaternion.Euler(0,Random.Range(0,360),0));
        spawnTreeGameObject.transform.localScale = new Vector3(Random.Range(0.9f, 1.5f), Random.Range(0.9f, 1.5f),
            Random.Range(0.9f, 1.5f));
        treeSpawnTimer = 0.3f;
    }
}
