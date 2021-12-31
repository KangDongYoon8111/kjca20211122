using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;

        if(a <= 69)
        {
            Debug.Log("F");
        }
        else if(a <= 70)
        {
            Debug.Log("C");
        }
        else if(a <= 80)
        {
            Debug.Log("B");
        }
        else
        {
            Debug.Log("A");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
