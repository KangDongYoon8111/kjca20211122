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
        Debug.Log($"��� : {a}�� ��� ���� {Pow(a)} �Դϴ�. ");
        Debug.Log($"��� : {b}�� ��� ���� {Pow(b)} �Դϴ�. ");
    }
    float Pow(float a)
    {
        float pow = a * a;
        return pow;
    }
    
}
