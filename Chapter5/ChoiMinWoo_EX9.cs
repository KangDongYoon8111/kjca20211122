using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_EX9 : MonoBehaviour
{ 
    // for (x = i%3 !=0)
    int i;
    int j;
    void Start()
    {
        for(i = 1; i < 11; i++)
        {
            if (i % 3 != 0)
            { print(i);
                j += i;  }     
        }
            Debug.Log($"1~10�� 3���� ������ �������� �ʴ� ���� �� : {j}");
            
    }

}
