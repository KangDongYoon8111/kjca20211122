using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_EX2 : MonoBehaviour
{
    /*
2. ���� �ڵ忡 Plus() �޼ҵ尡 float �� �Ű������� �����ϵ���
�����ε��ϼ���.�� ���α׷��� �ϼ��� ���� ���� ����� ������
���ƾ� �մϴ�.
�� ���(�ڵ�� ���� �������� �ֽ��ϴ�.)
    */
    void Start()
    {
        int a = 3;
        int b = 4;
        Debug.Log($"{a} + {b} = {Plus(a, b)}");
        float x = 2.4f;
        float y = 3.1f;
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
}
