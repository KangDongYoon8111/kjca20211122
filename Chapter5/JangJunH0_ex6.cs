using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunH0_ex6 : MonoBehaviour
{
    public string userInput1;
    public string userInput2;
    public string math;
    public void Start()
    {
        int num1 = int.Parse(userInput1);
        int num2 = int.Parse(userInput2);

        switch (math)
        {
            case "+":
                Debug.Log($"{num1 + num2}");
                break;
            case "-":
                Debug.Log($"{num1 - num2}");
                break;
            case "*":
                Debug.Log($"{num1 * num2}");
                break;
            case "/":
                Debug.Log($"{num1 / num2}");
                break;
            case "%":
                Debug.Log($"{num1 % num2}");
                break;
            default:
                Debug.Log("계산할수 없습니다.");
                break;

        }

    }
}
