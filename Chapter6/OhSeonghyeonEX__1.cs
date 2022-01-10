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

        Debug.Log($"결과 : 3 의 제곱값은 {multiply (a)}입니다.");
        Debug.Log($"결과 : 34.2 의 제곱값은 {multiply(b)}입니다.");

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
