using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX9 : MonoBehaviour
{
//1. 1~10���� ���� �߿��� 3���� ������ �������� �ʴ� ����
//����ϰ�, �� ������ ���� ���
    void Start()
    {
        int ������ = 0;
        for (int ���� = 1; ����<=10; ����++)
        {
            if(����%3 != 0)
            {
                Debug.Log(����);
                ������ = ������ + ����;
            }         
        }
        Debug.Log($"1~10���� 3�� ����� ������ �������� ��: {������}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
