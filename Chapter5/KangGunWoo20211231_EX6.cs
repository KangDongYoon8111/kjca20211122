using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX6 : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()

    {
        string c = "5";
        string d = "10";
        int a = int.Parse(c);
        int b = int.Parse(d);
        string e = "/";

        switch (e)
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
            default:
                Debug.Log("´Ù½Ã ÀÔ·ÂÇØ ÁÖ¼¼¿ä");
                break;
        }
    }
}
