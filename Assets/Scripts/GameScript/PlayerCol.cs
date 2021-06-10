using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCol : MonoBehaviour
{
    public GameObject restartUI;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            PlayerDies();
        }
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Gem")
        {
            //increase coin collection
            DataManager.dataManager.currentScore++;
            //play audio affect
            //increase score
            DataManager.dataManager.totalCoins++;
            Destroy(collider.gameObject);
        }
    }

    void PlayerDies()
    {
        DataManager.dataManager.SaveData();
        GameInit.gameIsPlaying = false;
        //activate UI for restarting game;
        restartUI.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerController>().enabled = false;
        GetComponent<PlayerMove>().enabled = false;
        GetComponent<ParticleSystem>().Play();
    }
}
