using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        int c = 3;

        if(a>b && a>c)
        {
            Debug.Log("최대값은 : " + a);
        }
        else if(b>a && b>c)
        {
            Debug.Log("최대값은 : " + b);
        }
        else
        {
            Debug.Log("최대값은 : " + c);
        }


        if (a < b && a < c)
        {
            Debug.Log("최소값은 : " + a);
        }
        else if (b < a && b < c)
        {
            Debug.Log("최소값은 : " + b);
        }
        else
        {
            Debug.Log("최소값은 : " + c);
        }


        Debug.Log("합계 : " + a + b + c);


        Debug.Log("평균 : " + (a + b + c) / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
