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

        Debug.Log("��� : " + (a) + "�� �������� " + Squared(c) + "�Դϴ�.");
        Debug.Log("��� : " + (b) + "�� �������� " + Squared(d) + "�Դϴ�.");
    }
    public static float Squared(float userInput)
    {
        return userInput * userInput;
    }
}
