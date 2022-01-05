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
            Debug.Log($"최대값은{max}입니다.");
        }
        else
        {
            max = b;
            if (max >= c) 
            {
                Debug.Log($"최대값은{max}입니다.");
            }
            else
            {
                max = c;  
            }
        }
        Debug.Log($"최대값은{max}입니다.");

        if(a<=b && a<=c)
        {
            min = a;
            Debug.Log($"최소값은{min}입니다.");
        }
        else
        {
            min = b;
            if (min<=c)
            {
                Debug.Log($"최소값은{min}입니다");
            }
            else
        Debug.Log($"최소값은{min}입니다");

        }

        sum = a + b + c;
        Debug.Log($"합계는{sum}입니다.");
        avg = sum / 3;
        Debug.Log($"평균은{avg}입니다.");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
