using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "2";
        string userInput2 = "6";
        float a = float.Parse(userInput1);
        float b = float.Parse(userInput2);
        Debug.Log("��� :" + a+"�� �������� "+ Multiply1(a, a)+" �Դϴ�");
        Debug.Log("��� :" + b + "�� �������� " + Multiply1(b, b) + " �Դϴ�");

    }

    public static float Multiply1(float a, float b)
    {
        

         float result1 = a * a;
        return result1;
    }
    public static float Multiply2(float a, float b)
    {
        

        float result2 = b * b;
        return result2;
    }


}
