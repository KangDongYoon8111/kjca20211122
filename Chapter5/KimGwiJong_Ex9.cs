using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex9 : MonoBehaviour
{
    // 1. 1~10까지 정수 중에서 3으로 나누어 떨어지지 않는 수를
    // 출력하고, 이 수들의 합을 출력

    void Start()
    {
        int sum = 0;
        for(int i = 1; i<=10; i++)
        {
            if(i%3 != 0)
            {
                Debug.Log(i);
                sum = sum + i;
            }      
        }
        Debug.Log($"1~10중 떨어지지 않는 수의 합:{sum}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
