using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "11";
        string b = "5";
        string c = "%";
        int d = int.Parse(a);
        int e = int.Parse(b);
        int f = 0;
        switch (c)
        {
            case "+":
                f = d + e;
                break;
            case "-":
                f = d - e;
                break;
            case "*":
                f = d * e;
                break;
            case "/":
                f = d / e;
                break;
            case "%":
                f = d % e;
                break;
            default:
                Debug.Log("¿À·ù");
                break;
        }
        Debug.Log(f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
