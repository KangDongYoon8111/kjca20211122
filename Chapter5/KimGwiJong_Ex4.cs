using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    //����ڷκ��� �� ���� ������ �Է¹޾�, 
    //�� ������ �ִ밪�� �ּҰ�,
    //�հ�� ����� ���ϴ� ���α׷���
    //������ּ���.

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
        Debug.Log($"ū��: {max}");
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
        Debug.Log($"������: {min}");
    }
    void Sum(int a, int b, int c)
    {
        sum = a + b + c;
        Debug.Log($"�հ�: {sum}");
    }

    void Average(int a, int b, int c)
    {
        average = (a + b + c) / 3;
        Debug.Log($"���: {average}");
    }
}
