using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhsangMok_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 90;
       

        if (a % 3== 0) //3�� ���� �������� ���� �� (�������� 0�� �ƴ� ��)
        {
            Debug.Log("�Է��� ���� 3�� ��� �Դϴ�.");
        }
        else //3�� ���� �������� ������ �� (�������� 0�� ��)
        {
            Debug.Log("�Է��� ���� 3�� ����� �ƴմϴ�.");
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
