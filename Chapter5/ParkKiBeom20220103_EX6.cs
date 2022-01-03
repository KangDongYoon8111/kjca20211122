using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220103_EX6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "15";
        string userInput2 = "30";
        string value = "-"; // +, -, *, /, %


        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        int output = 0;
        
        switch (value)
        {
            case "+":
                output = a + b;
                break;
            case "-":
                output = a - b;
                break;
            case "*":
                output = a * b;
                break;
            case "/":
                output = a / b;
                break;
            case "%":
                output = a % b;
                break;
            default:
                Debug.Log("(+,-,*,/,%)만 사용할 수 있습니다.");
                break;

        }

        Debug.Log(output);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
