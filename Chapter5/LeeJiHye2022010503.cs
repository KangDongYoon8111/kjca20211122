using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJiHye2022010503 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
            ���� �� ���� �Է¹޾Ƽ�,
            �� ���� 3�� �������
            �Ǵ��ϴ� ���α׷���
            ������ּ���.
        */
        string Userinput = "90";
        int a = int.Parse(Userinput);

        if (a % 3 == 0)
        {
            Debug.Log("3�� ����Դϴ�.");
        }
        else
        {
            Debug.Log("3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
