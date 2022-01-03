using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
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
                outPut = a / b;
                break;
            default:
                Debug.Log("ㅁ7");
                break;
        }
        Debug.Log(outPut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
