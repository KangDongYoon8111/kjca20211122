using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX4 : MonoBehaviour
{
      public int a ; 
      public int b ;
      public int c ;
    int max;
    int min;
    int sum;
    int avg;
    void Start()
    {

        if(a>=b && a>=c)
        {
            max = a;
            Debug.Log($"�ִ밪��{max}�Դϴ�.");
        }
        else
        {
            max = b;
            if (max >= c) 
            {
                Debug.Log($"�ִ밪��{max}�Դϴ�.");
            }
            else
            {
                max = c;  
            }
        }
        Debug.Log($"�ִ밪��{max}�Դϴ�.");

        if(a<=b && a<=c)
        {
            min = a;
            Debug.Log($"�ּҰ���{min}�Դϴ�.");
        }
        else
        {
            min = b;
            if (min<=c)
            {
                Debug.Log($"�ּҰ���{min}�Դϴ�");
            }
            else
        Debug.Log($"�ּҰ���{min}�Դϴ�");

        }

        sum = a + b + c;
        Debug.Log($"�հ��{sum}�Դϴ�.");
        avg = sum / 3;
        Debug.Log($"�����{avg}�Դϴ�.");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
