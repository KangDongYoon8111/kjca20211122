using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex7 : MonoBehaviour
{
    //�� ���� ���� �Ѵް��� ��¥ ����
    //�˷��ִ� ���α׷��� ������ּ���.
    //ex) ����� �ñ��ϼ���? 7
    // 7���� : 31�� ���� �ֽ��ϴ�.

    string input = "1";
    

    void Start()
    {
        int month = int.Parse(input);

        switch (month)
        {
            case 1:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 2:
                Debug.Log($"{month}���� 28�ϱ��� �ֽ��ϴ�.");
                break;
            case 3:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 4:
                Debug.Log($"{month}���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 5:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 6:
                Debug.Log($"{month}���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 7:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 8:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 9:
                Debug.Log($"{month}���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 10:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
            case 11:
                Debug.Log($"{month}���� 30�ϱ��� �ֽ��ϴ�.");
                break;
            case 12:
                Debug.Log($"{month}���� 31�ϱ��� �ֽ��ϴ�.");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
