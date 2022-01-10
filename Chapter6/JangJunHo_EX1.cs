using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "3";
        string userInput2 = "34.2";
        int a = int.Parse(userInput1);
        float b = float.Parse(userInput2);
        Debug.Log($"결과 : {a}의 결과 값은 {Pow(a)} 입니다. ");
        Debug.Log($"결과 : {b}의 결과 값은 {Pow(b)} 입니다. ");
    }
    float Pow(float a)
    {
        float pow = a * a;
        return pow;
    }
    
}
