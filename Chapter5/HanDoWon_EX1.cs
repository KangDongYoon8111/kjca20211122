using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int a = 69;

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

        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
