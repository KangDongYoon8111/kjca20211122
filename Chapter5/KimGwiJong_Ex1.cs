using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� �ȳ� ���α׷�
        // ������� ������ �Է¹޾� 90�� �̻��� "A",
        // 80�� �̻��� "B", 70�� �̻��� "C",
        // 69�� ���� ������ "F"�� ��µǴ� ���α׷���
        // ����� �ּ���.

        string inputText = "95";
        int jumsu = int.Parse(inputText);

        if(jumsu >= 90)
        {
            Debug.Log("A");
        }else if(jumsu >= 80)
        {
            Debug.Log("B");
        }else if (jumsu >= 70)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
