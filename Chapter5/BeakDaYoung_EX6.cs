using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX6 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        string a = "1";
        string b = "2";
        string c = "+";
        
        int d = int.Parse(a);
        int e = int.Parse(b);

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
