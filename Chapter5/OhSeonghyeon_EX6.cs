using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string number1 = "50";
        string number2 = "60";
        string mathematics = "+";  // -./ *

        int a = int.Parse(number1);
        int b = int.Parse(number2);
        int output;  
        switch (mathematics)
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





        }
        Debug.Log(output);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
