using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex7 : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("����� �ñ��ϼ���?");
        string userInput = "1";
        int num1 = int.Parse(userInput);

        switch (num1)
        {
            case 1:
                Debug.Log("1���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 2:
                Debug.Log("2���� 28(29)�ϱ��� �ֽ��ϴ�.");
                break;
            case 3:
                Debug.Log("3���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 4:
                Debug.Log("4���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 5:
                Debug.Log("5���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 6:
                Debug.Log("6���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 7:
                Debug.Log("7���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 8:
                Debug.Log("8���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 9:
                Debug.Log("9���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 10:
                Debug.Log("10���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 11:
                Debug.Log("11���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 12:
                Debug.Log("12���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            default:
                Debug.Log("�Է°� ����");
                break;
        }
    }
}