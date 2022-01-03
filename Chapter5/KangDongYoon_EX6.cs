using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangDongYoon_EX6 : MonoBehaviour
{
    void Start()
    {

        string userInput1 = "100";
        string userInput2 = "10";
        string value = "-"; // +,-,*,/,%

        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        int outPut = 0;
        switch (value)
        {
            case "+":
                outPut = a + b;
                break;
            case "-":
                outPut = a - b;
                break;
            case "*":
                outPut = a * b;
                break;
            case "/":
                outPut = a / b;
                break;
            case "%":
                outPut = a % b;
                break;
        }
        Debug.Log(outPut);
    }

    void Update()
    {
        
    }
}
