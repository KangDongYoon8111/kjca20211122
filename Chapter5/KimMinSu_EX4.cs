using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 15;
        int c = 20;
        int x = a + b + c;
        int y = x / 3;
        if (a >= b)
        {
            if( a >= c)
            {
                Debug.Log($"�ִ�:{a}");
            }
        }
  
        else if(b >= c)
        {
            Debug.Log($"�ִ�:{b}");
          
                  
        }
        else
        {
            Debug.Log($"�ִ�:{c}");
        }

        if (a <= b)
        {
            if (a <= c)
            {
                Debug.Log($"�ּҰ�:{a}");
            }
        }

        else if (b <= c)
        {
            Debug.Log($"�ּҰ�:{b}");


        }
        else
        {
            Debug.Log($"�ּҰ�:{c}");
        }
        Debug.Log("�հ� : "+x);
        Debug.Log("��� : " + y);

    }

}

        
    


   
