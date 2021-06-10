using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public int rotateSpeed;
 
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.fixedDeltaTime);
    }
}
