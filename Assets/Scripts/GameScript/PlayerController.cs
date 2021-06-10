using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float jetPackFuel = 1.5f;
    public float jetPackForce = 10.0f;
    //public GameObject jetPack;
    void Update()
    {
        if(Input.GetButton("Jump") && jetPackFuel > 0.01)
        {
            BoostUp();
            //jetPack.GetComponent<ParticleSystem>().Play();
        }
        // else
        // {
        //     jetPack.GetComponent<ParticleSystem>().Stop();
        // }
    }

    void BoostUp()
    {
        jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jetPackFuel = 1.5f;
        }
    }
}
