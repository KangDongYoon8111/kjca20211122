using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int firstGrade = 110;
        int secondGrade = -110;
        int thirdGrade = 60;
        int fourthGrade = 60;

        if (firstGrade >= 60 && firstGrade <= 100)
        {
            Debug.Log("�հ�");
        }
        else if (firstGrade < 60 && firstGrade >= 0)
        {
            Debug.Log("���հ�");
        }
        else
        {
            Debug.Log("���ڿ� ������ �ֽ��ϴ�.");
        }

        
        if (secondGrade >= 60 && secondGrade <= 100)
        {
            Debug.Log("�հ�");
        }
        else if (secondGrade < 60 && secondGrade >= 0)
        {
            Debug.Log("���հ�");
        }
        else
        {
            Debug.Log("���ڿ� ������ �ֽ��ϴ�.");
        }


        if (thirdGrade >= 60 && thirdGrade <= 100)
        {
            Debug.Log("�հ�");
        }
        else if (thirdGrade < 60 && thirdGrade >= 0)
        {
            Debug.Log("���հ�");
        }
        else
        {
            Debug.Log("���ڿ� ������ �ֽ��ϴ�.");
        }


        if (fourthGrade >= 70 && fourthGrade <= 100)
        {
            Debug.Log("�հ�");
        }
        else if (fourthGrade < 70 && fourthGrade >= 0)
        {
            Debug.Log("���հ�");
        }
        else
        {
            Debug.Log("���ڿ� ������ �ֽ��ϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
