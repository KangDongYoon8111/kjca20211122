using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex5 : MonoBehaviour
{
    void Start()
    {
        string userInput = "60";
        string userInput2 = "50";
        string userInput3 = "101";
        string userInput4 = "80";
        int num1 = int.Parse(userInput);
        int num2 = int.Parse(userInput2);
        int num3 = int.Parse(userInput3);
        int num4 = int.Parse(userInput4);

        if (num1 >= 60 && num1 <= 100)
            Debug.Log("1학년 합격");
        else if (num1 < 0 || num1 > 100)
            Debug.Log("입력값 오류");
        if (num2 >= 60 && num2 <= 100)
            Debug.Log("2학년 합격");
        else if (num2 < 0 || num2 > 100)
            Debug.Log("입력값 오류");
        if (num3 >= 60 && num3 <= 100)
            Debug.Log("3학년 합격");
        else if (num3 < 0 || num3 > 100)
            Debug.Log("입력값 오류");
        if (num4 >= 70 && num4 <= 100)
            Debug.Log("4학년 합격");
        else if (num4 < 0 || num4 > 100)
            Debug.Log("입력값 오류");
    }

}
