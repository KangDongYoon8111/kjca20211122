using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex9 : MonoBehaviour
{
    // 1. 1~10���� ���� �߿��� 3���� ������ �������� �ʴ� ����
    // ����ϰ�, �� ������ ���� ���

    void Start()
    {
        int sum = 0;
        for(int i = 1; i<=10; i++)
        {
            if(i%3 != 0)
            {
                Debug.Log(i);
                sum = sum + i;
            }      
        }
        Debug.Log($"1~10�� �������� �ʴ� ���� ��:{sum}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
