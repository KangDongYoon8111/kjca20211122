using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX4 : MonoBehaviour
{
    /*
    ����ڷκ��� �� ���� ������ �Է¹޾�, 
�� ������ �ִ밪�� �ּҰ�,
�հ�� ����� ���ϴ� ���α׷���
������ּ���.
    */
    void Start()
    {
        int a = 2;
        int b = 3;
        int c = 1;
        int max = 0;
        int min = 0;

        if (a > b)
        {
            max = a;
        }

        if (b > c)
        {
            max = b;
        }

        if(c > max)
        {
            max = c;
        }
        Debug.Log($"�ִ밪:{max}");

        if (a < b)
        {
            min = a;
        }

        if (b < c)
        {
            min = b;
        }

        if (c < min)
        {
            min = c;
        }
        Debug.Log($"�ּҰ�:{min}");
        Debug.Log($"�հ�:{a+b+c}");
        Debug.Log($"���:{(a + b + c)/3}");
    }


    void Update()
    {
        
    }
}
