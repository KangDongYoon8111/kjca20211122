using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string Input1 = "3";
        string Input2 = "34.2";

        int a = int.Parse(Input1);
        float b = float.Parse(Input2);

        Debug.Log($"{a}의 제곱값은 { squared(a)} 입니다.");
        Debug.Log($"{b}의 제곱값은 { squared(b)} 입니다.");
    }

    int squared(int a)
    {
        int b = a * a;
        return b;
    }
    float squared(float a)
    {
        float b = a * a;
        return b;
    }
}
