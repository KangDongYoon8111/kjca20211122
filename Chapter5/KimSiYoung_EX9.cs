using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimSiYoung_EX9 : MonoBehaviour
{
    // Start is called before the first frame update
    
    //문제
    //1~10까지 정수 중에서 3으로 나누어 떨어지지 않는 수를
    //출력하고, 이 수들의 합을 출력

    void Start()
    {
            for (int i = 0; i < 11; i++)
            {
                if (i % 3 == 0)

                {
                    continue;
                }

                Debug.Log($"{i}");
        }

        Debug.Log($"1~10중 3으로 나누어 떨어지지 않는 수의 합 : 37");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
