using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex2 : MonoBehaviour
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
        string input = "50";
        int integer1 = int.Parse(input);

        if(integer1>=50)
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
