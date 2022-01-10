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
        Debug.Log("결과 :" + a+"의 제곱값은 "+ Squared1(a, a)+" 입니다");
        Debug.Log("결과 :" + b + "의 제곱값은 " + Squared2(b, b) + " 입니다");
    }

    public static float Squared1(float a, float b)
    {
        

         float result1 = a * a;
        return result1;
    }
    public static float Squared2(float a, float b)
    {
        

        float result2 = b * b;
        return result2;
    }


}
