using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeonEX__1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "3";
        string userInput2 = "34.2";

        int a = int.Parse(userInput1);
        float b = float.Parse(userInput2);

        Debug.Log($"��� : 3 �� �������� {multiply (a)}�Դϴ�.");
        Debug.Log($"��� : 34.2 �� �������� {multiply(b)}�Դϴ�.");

    }
    int multiply(int a)
    {
        int multiply = a * a;
        return multiply;
    }
    float multiply(float b)
    {
        float multiply = b * b;
        return multiply;

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
