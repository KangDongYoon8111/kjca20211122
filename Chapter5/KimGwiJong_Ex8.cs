using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex8 : MonoBehaviour
{
    //����ڿ��� ���� �Է¹޾� �ش��ϴ� ������ 
    //����ϴ� ���α׷��� ������ּ���.
    //03��~05�� : ��, 06��~08�� : ����,
    //09��~11�� : ����, 12��~02�� : �ܿ�

    string input = "3��";

    void Start()
    {
        int month = int.Parse(input[0].ToString());
        


        switch (month)
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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
