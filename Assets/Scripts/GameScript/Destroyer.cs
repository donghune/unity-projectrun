using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private float timeTillDestroy = 10.0f;

    void Update()
    {
        timeTillDestroy -= Time.deltaTime;
        if (timeTillDestroy < 0.01 && GameInit.gameIsPlaying)
        {
            Destroy(gameObject);
        }
    }
}