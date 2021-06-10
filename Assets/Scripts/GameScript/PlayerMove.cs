using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static int playerSpeed =20 ;
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.right * playerSpeed * Time.fixedDeltaTime);
    }
}
