using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX2 : MonoBehaviour
{
    void Start()
    {
        int a = 3;
        int b = 5;
        Debug.Log($"{a} + {b} = {Plus(a, b)}");
        float x = 2.4f;
        float y = 3.3f;
        Debug.Log($"{x} + {y} = {Plus(x, y)}");
    }
    public int Plus(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    public float Plus(float a, float b)
    {
        float sum = a + b;
        return sum;
    }

    // �� �Ʒ��� float �� �Ű������� ���� ���ֵ���
    // �����ε��� Plus() �޼ҵ带 �ۼ��ϼ���.
}

