using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    public float cameraSpeed = 3.0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
 
    void FixedUpdate()
    {
        //X position follow
        Vector3 cameraPosision = transform.position;
        cameraPosision.x = player.transform.position.x+8.0f;
        transform.position = Vector3.Lerp(transform.position, cameraPosision, 3 * Time.fixedDeltaTime);

        //Y position follow
        cameraPosision.y = player.transform.position.y + 2;
        transform.position = Vector3.Lerp(transform.position, cameraPosision, 7.0f * Time.fixedDeltaTime);

        if (GameInit.gameIsPlaying == false)
        {
            cameraPosision.x = player.transform.position.x - 15.0f;
            transform.position = cameraPosision;
        }
    }
}
