using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX9 : MonoBehaviour
{
//1. 1~10까지 정수 중에서 3으로 나누어 떨어지지 않는 수를
//출력하고, 이 수들의 합을 출력
    void Start()
    {
        int 숫자합 = 0;
        for (int 정수 = 1; 정수<=10; 정수++)
        {
            if(정수%3 != 0)
            {
                Debug.Log(정수);
                숫자합 = 숫자합 + 정수;
            }         
        }
        Debug.Log($"1~10까지 3의 배수를 제외한 나머지의 합: {숫자합}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
