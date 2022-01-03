using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        int b;
        switch (a)
        {
            case "+";
                Debug.Log(a + b);
                break;
            case "-";
                Debug.Log(a - b);
                break;
            case "*";
                Debug.Log(a * b);
                break;
            case "/";
                Debug.Log(a / b);
                break;
            case "%";
                Debug.Log(a % b);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
