using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunho_ex8 : MonoBehaviour
{
    public void Start()
    {
        string userInput = "4";
        int num1 = int.Parse(userInput);
        switch (num1)
        {
            case 1:
                Debug.Log("�ܿ�");
                break;
            case 2:
                Debug.Log("�ܿ�");
                break;
            case 3:
                Debug.Log("��");
                break;
            case 4:
                Debug.Log("��");
                break;
            case 5:
                Debug.Log("��");
                break;
            case 6:
                Debug.Log("����");
                break;
            case 7:
                Debug.Log("����");
                break;
            case 8:
                Debug.Log("����");
                break;
            case 9:
                Debug.Log("����");
                break;
            case 10:
                Debug.Log("����");
                break;
            case 11:
                Debug.Log("����");
                break;
            case 12:
                Debug.Log("�ܿ�");
                break;
            default:
                Debug.Log("1~12������ ������ �Է����ּ���");
                break;
        }
    }
}
