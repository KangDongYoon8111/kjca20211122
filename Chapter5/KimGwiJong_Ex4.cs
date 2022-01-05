using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    //사용자로부터 세 개의 정수를 입력받아, 
    //그 수들의 최대값과 최소값,
    //합계와 평균을 구하는 프로그램을
    //만들어주세요.

    string input1 = "40";
    string input2 = "50";
    string input3 = "10";

    int max = 0;
    int min = 0;
    int sum = 0;
    float average = 0.0f;

    void Start()
    {
        int a = int.Parse(input1);
        int b = int.Parse(input2);
        int c = int.Parse(input3);

        Max(a, b, c);
        Min(a, b, c);
        Sum(a, b, c);
        Average(a, b, c);
    }

    void Max(int a, int b, int c)
    {
        max = a;

        if (a >= max)
        {
            max = a;
        }
        if (b >= max)
        {
            max = b;
        }
        if (c >= max)
        {
            max = c;
        }
        Debug.Log($"큰수: {max}");
    }
    void Min(int a, int b, int c)
    {
        min = a;

        if (a <= min)
        {
            min = a;
        }
        if (b <= min)
        {
            min = b;
        }
        if (c <= min)
        {
            min = c;
        }
        Debug.Log($"작은수: {min}");
    }
    void Sum(int a, int b, int c)
    {
        sum = a + b + c;
        Debug.Log($"합계: {sum}");
    }

    void Average(int a, int b, int c)
    {
        average = (a + b + c) / 3;
        Debug.Log($"평균: {average}");
    }
}
