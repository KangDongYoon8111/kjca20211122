using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex4 : MonoBehaviour
{
    void Start()
    {
        string userInput = "3";
        string userInput2 = "7";
        string userInput3 = "9";
        int num1 = int.Parse(userInput);
        int num2 = int.Parse(userInput2);
        int num3 = int.Parse(userInput3);

        if (num1 > num2 && num1 > num3 && num2 > num3)
            Debug.Log($"최대값 : {num1}, 최소값 :{num3}");
        else if (num1 > num2 && num1 > num3 && num3 > num2)
            Debug.Log($"최대값 : {num1}, 최소값 :{num2}");
        else if (num2 > num1 && num2 > num3 && num1 > num3)
            Debug.Log($"최대값 : {num2}, 최소값 :{num3}");
        else if (num2 > num1 && num2 > num3 && num3 > num1)
            Debug.Log($"최대값 : {num2}, 최소값 :{num1}");
        else if (num3 > num1 && num3 > num2 && num1 > num2)
            Debug.Log($"최대값 : {num3}, 최소값 :{num2}");
        else if (num3 > num1 && num3 > num2 && num2 > num1)
            Debug.Log($"최대값 : {num3}, 최소값 :{num1}");


        Debug.Log($"합계 : {num1 + num2 + num3}");
        Debug.Log($"평균 : { (num1 + num2 + num3) / 3}");
    }

}
