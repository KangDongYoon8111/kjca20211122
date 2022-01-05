using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string x = "1";
        string y = "3";
        string z = "-";//+,-,,/,%

        int a = int.Parse(x);
        int b = int.Parse(y);

        switch (z)
        {
            case "+":
                Debug.Log(a + b);
                break;
            case "-":
                Debug.Log(a - b);
                break;
            case "*":
                Debug.Log(a * b);
                break;
            case "/":
                Debug.Log(a / b);
                break;
            case "%":
                Debug.Log(a % b);
                break;
        }

    }
}

