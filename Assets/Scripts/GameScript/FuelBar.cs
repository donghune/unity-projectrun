using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{     
    void Update()
    {
        adjustFuelBar();
    }

    void adjustFuelBar()
    {
        if(PlayerController.jetPackFuel > 0.001)
        {
            gameObject.transform.localScale = new Vector3(PlayerController.jetPackFuel, 1, 1);
        }
    }
}
