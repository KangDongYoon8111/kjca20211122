using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGwiJong_Ex5 : MonoBehaviour
{
    // �����ʵ��б����� 1�г���� 4�г���� �߰����
    //������ ���Ҵ�.
    //4�г��� 70�� �̻��̸� �հ�, �� �̿��� �г��� 60��
    //�̻��̸� �հ��̴�.
    //�̸� �Ǵ��ϴ� ���α׷��� ������ּ���.
    //������ 0�̸� 100�ʰ��̸� ����� ���!

    string inputGrade = "5�г�";
    string inputScore = "70";
    void Start()
    {

        int grade = int.Parse(inputGrade[0].ToString());
        int score = int.Parse(inputScore);

        if (score < 0 || score > 100)
        {
            Debug.Log($"�����Է� ����! ����: {score}");
        }
        else if (grade == 4)
        { 
            if (score >= 70)
            {
                Debug.Log($"4�г� �հ� ����: {score}");
            }

        }
        else if (grade >= 1 && grade < 4)
        {
            if (score >= 60)
            {
                Debug.Log($"{grade}�г� �հ� ����: {score}");
            }
        }
        else
        {
            Debug.Log("�г��Է¿���");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
