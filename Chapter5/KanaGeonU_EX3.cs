using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX3 : MonoBehaviour
{
//    ���� �� ���� �Է¹޾Ƽ�,
//�� ���� 3�� �������
//�Ǵ��ϴ� ���α׷���
//������ּ���.
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        if(a%3 == 0)
        {
            Debug.Log("3�� ���");
        }
        else
        {
            Debug.Log("3�� ����� �ƴմϴ�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
