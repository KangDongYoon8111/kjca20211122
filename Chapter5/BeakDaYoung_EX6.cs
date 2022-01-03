using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX6 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        string c = "+";
        int a = 1;
        int b = 2;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
