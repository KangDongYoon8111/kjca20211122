using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhsangMok_EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = 1;
        int b = 2;
        int c = 3;
              
            if (a > b && a > c)
            {
                Debug.Log("최대값"+a);
            }
            else if (b > c && b > c)
            {
                Debug.Log("최대값"+b);
            }
            else
            {
                Debug.Log("최대값"+c);
            }
        if (a < b && a < c)
        {
            Debug.Log("최소값" + a);
        }
        else if (b < c && b < c)
        {
            Debug.Log("최소값" + b);
        }
        else
        {
            Debug.Log("최소값" + c);
        }
        Debug.Log((a + b +  c)/3);
        Debug.Log(a + b + c);

    }
}
