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
                Debug.Log($"{a} + {b}�� ���� {c}");
                    break;
            case '-':
                c = a - b;
                Debug.Log($"{a} - {b}�� ���� {c}");
                break;
            case '*':
                c = a * b;
                Debug.Log($"{a} * {b}�� ���� {c}");
                break;
            case '/':
                c = a / b;
                Debug.Log($"{a} / {b}�� ���� {c}");
                break;
            case '%':
                c = a % b;
                Debug.Log($"{a} % {b}�� ���� {c}");
                break;
            default:
                Debug.Log("�ǹٸ� �����ڰ� �ƴմϴ�.");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}