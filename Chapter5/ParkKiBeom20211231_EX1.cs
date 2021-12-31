using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20211231_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int a = 90;

        if (a >= 90)
        {
            Debug.Log("A");
        }
        else if (a >= 80)
        {
            Debug.Log("B");
        }
        else if (a >= 70)
        {
            Debug.Log("C");
        }
        else if (a < 70)
        {
            Debug.Log("F");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
