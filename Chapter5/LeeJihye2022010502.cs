using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJihye2022010502 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        ���� �� ���� �Է¹޾Ƽ�,
        �� ���� 50 �̻��� ������
        50�̸��� ������
        �Ǵ��ϴ� ���α׷��� ����� �ּ���.
        */
        string Userinput = "50";
        int a = int.Parse(Userinput);

        if (a >= 50)
        {
            Debug.Log("50 �̻��Դϴ�.");
        }
        else
        {
            Debug.Log("50 �̸��Դϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
