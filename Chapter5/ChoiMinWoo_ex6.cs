using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int a;
    public int b;
    public char Operator;
    float c;
    void Start()
    {
        switch (Operator)
        {
            case '+':
                c = a + b;
                Debug.Log($"{a} + {b}의 값은 {c}");
                    break;
            case '-':
                c = a - b;
                Debug.Log($"{a} - {b}의 값은 {c}");
                break;
            case '*':
                c = a * b;
                Debug.Log($"{a} * {b}의 값은 {c}");
                break;
            case '/':
                c = a / b;
                Debug.Log($"{a} / {b}의 값은 {c}");
                break;
            case '%':
                c = a % b;
                Debug.Log($"{a} % {b}의 값은 {c}");
                break;
            default:
                Debug.Log("옳바른 연산자가 아닙니다.");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}