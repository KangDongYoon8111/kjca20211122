using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSangMokEX6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string c = "+";
        int a = 100;
        int b = 200;

        switch (c)
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
