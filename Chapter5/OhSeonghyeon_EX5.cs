using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string userInput1 = "70"; //4�г�
        int a = int.Parse(userInput1);
        string userInput2 = "59";  // �� �� �г�
        int b = int.Parse(userInput2);
        int c = a + b;

        if (c <= 200)

        {
            if (a >= 70)
            { Debug.Log("�հ�"); }
            else if (a < 70)
            { Debug.Log("���հ�"); }

            if (b >= 60)
            { Debug.Log("�հ�"); }
            else if (b < 60)
            { Debug.Log("���հ�"); }
        }
            else
            {
                if (a < 0)
                { Debug.Log("0�� �̸� ���"); }
                else if (a > 100)
                { Debug.Log("100�� �ʰ� ���"); }
                if (b < 0)
                { Debug.Log("0�� �̸� ���"); }
                else if (b > 100)
                { Debug.Log("100�� �ʰ� ���"); }

            }

            // Update is called once per frame
            void Update()
            {

            }
    }
 }

