using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex3 : MonoBehaviour
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
        string input = "30";
        int integer1 = int.Parse(input);

        if (integer1 % 3 == 0)
        {
            Debug.Log("3�� �����Դϴ�.");
        }
        else
        {
            Debug.Log("3�� ������ �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
