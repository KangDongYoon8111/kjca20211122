using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220104_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "4�г�";
        string userInput2 = "4�г� �̿��� �г�";
        string userInput3 = "72";
        string grade = "4�г�";
        int a = int.Parse(userInput3);

        if (grade == userInput1)
        {
            if (70 <= a && a <= 100 && 0 < a)
                Debug.Log(grade + "�̸�" + a + "������ 70�� �̻��̹Ƿ� �հ�!");


            else if (grade == userInput2)
            {
                if (60 <= a && a <= 100 && 0 < a)
                    Debug.Log(grade + "�̸�" + a + "������ 60�� �̻��̹Ƿ� �հ�!");
            }
            else if (0 > a)
            {
                Debug.Log("*��� : 0�� �̸��Դϴ�.");
            }
            else if (100 < a)
            {
                Debug.Log("*��� : 100���� �ʰ� �Ͽ����ϴ�.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
