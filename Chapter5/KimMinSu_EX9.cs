using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++ )
        { 
          if( i %3 != 0)
            {
                Debug.Log(i);
            }
          
        }
        int sum = 0;
        int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < d.Length; i++)
        {
            if (d[i]%3 != 0)
            {
                sum += d[i]; 
            }
        }
        Debug.Log(sum);
    }
}
