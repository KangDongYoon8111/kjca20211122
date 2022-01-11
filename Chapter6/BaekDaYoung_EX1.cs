using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaekDaYoung_EX1 : MonoBehaviour
{
    private void Start()
    {
        string a = "3";
        string b = "34.2";

        int c = int.Parse(a);
        float d = float.Parse(b);

        Debug.Log("결과 : " + (a) + "의 제곱값은 " + Squared(c) + "입니다.");
        Debug.Log("결과 : " + (b) + "의 제곱값은 " + Squared(d) + "입니다.");
    }
    public static float Squared(float userInput)
    {
        return userInput * userInput;
    }
}
