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
            Debug.Log("�ִ밪�� : " + a);
        }
        else if(b>a && b>c)
        {
            Debug.Log("�ִ밪�� : " + b);
        }
        else
        {
            Debug.Log("�ִ밪�� : " + c);
        }


        if (a < b && a < c)
        {
            Debug.Log("�ּҰ��� : " + a);
        }
        else if (b < a && b < c)
        {
            Debug.Log("�ּҰ��� : " + b);
        }
        else
        {
            Debug.Log("�ּҰ��� : " + c);
        }


        Debug.Log("�հ� : " + a + b + c);


        Debug.Log("��� : " + (a + b + c) / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
