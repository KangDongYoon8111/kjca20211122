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
                Debug.Log($"최댓값:{a}");
            }
        }
  
        else if(b >= c)
        {
            Debug.Log($"최댓값:{b}");
          
                  
        }
        else
        {
            Debug.Log($"최댓값:{c}");
        }

        if (a <= b)
        {
            if (a <= c)
            {
                Debug.Log($"최소값:{a}");
            }
        }

        else if (b <= c)
        {
            Debug.Log($"최소값:{b}");


        }
        else
        {
            Debug.Log($"최소값:{c}");
        }
        Debug.Log("합계 : "+x);
        Debug.Log("평균 : " + y);

    }

}

        
    


   
