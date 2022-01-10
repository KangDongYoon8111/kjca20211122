using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_EX2_c6 : MonoBehaviour
{
    void Start()
    {
        int a = 3;
        int b = 4;
        Debug.Log($"{a}+{b}={Plus(a, b)}");

        float c = 2.4f;
        float d = 3.1f;
        Debug.Log($"{c}+{d}={Plus(c, d)}");

    }
    int Plus(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    float Plus(float a, float b)
    {
        float sum = a + b;
        return sum;
    }
}
