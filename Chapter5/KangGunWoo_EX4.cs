using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX4 : MonoBehaviour
{
    /*
    사용자로부터 세 개의 정수를 입력받아, 
그 수들의 최대값과 최소값,
합계와 평균을 구하는 프로그램을
만들어주세요.
    */
    void Start()
    {
        int a = 2;
        int b = 3;
        int c = 1;
        int max = 0;
        int min = 0;

        if (a > b)
        {
            max = a;
        }

        if (b > c)
        {
            max = b;
        }

        if(c > max)
        {
            max = c;
        }
        Debug.Log($"최대값:{max}");

        if (a < b)
        {
            min = a;
        }

        if (b < c)
        {
            min = b;
        }

        if (c < min)
        {
            min = c;
        }
        Debug.Log($"최소값:{min}");
        Debug.Log($"합계:{a+b+c}");
        Debug.Log($"평균:{(a + b + c)/3}");
    }


    void Update()
    {
        
    }
}
