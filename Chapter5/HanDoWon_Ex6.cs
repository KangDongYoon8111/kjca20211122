using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_Ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput1 = "1";
        string userinput2 = "3";
        string userinput3 = "-";//+,-,,/,%

        int a = int.Parse(userinput1);
        int b = int.Parse(userinput2);

        switch (userinput3)
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