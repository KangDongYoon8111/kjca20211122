using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX5 : MonoBehaviour
{
//    �����ʵ��б����� 1�г���� 4�г���� �߰����
//������ ���Ҵ�.
//4�г��� 70�� �̻��̸� �հ�, �� �̿��� �г��� 60��
//�̻��̸� �հ��̴�.
//�̸� �Ǵ��ϴ� ���α׷��� ������ּ���.
//������ 0�̸� 100�ʰ��̸� ����� ���
    // Start is called before the first frame update
    void Start()
    {
        int score = 50;
        int grade = 2;

        if( score < 0 || score > 100)
        {
            Debug.Log("�߸��� score�Դϴ�");
        }
        else if(grade==4)
        {
            if (score >= 70)
            {
                Debug.Log("�հ�");
            }
            else
            {
                Debug.Log("���հ�");
            }
        }else if(grade<4 && grade >= 1)
        {
            if (score >= 60)
            {
                Debug.Log("�հ�");
            }
            else
            {
                Debug.Log("���հ�");
            }
        }
        else
        {
            Debug.Log("�߸��� �г��� �Է��ϼ̽��ϴ�");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
