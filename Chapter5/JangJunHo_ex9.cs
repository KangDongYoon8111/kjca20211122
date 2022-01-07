using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex9 : MonoBehaviour
{
    void Start()
    {
        int j = 0;
        int k = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 != 0)
            {
                j = i;
                k += j;
            }
            Debug.Log(j);
            
            
        }
        Debug.Log($"гую╨{k}");
    }

}
