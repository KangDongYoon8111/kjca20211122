using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJiHye2022010504 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start is called before the first frame update
        //����ڷκ��� �� ���� ������ �Է¹޾�, 
        //�� ������ �ִ밪�� �ּҰ�,
        //�հ�� ����� ���ϴ� ���α׷���
        //������ּ���.

        string Userinput1 = "100";
        string Userinput2 = "70";
        string Userinput3 = "10";

        int max = 0;
        int min = 0;
        int sum = 0;
        float average = 0.0f;

        
        {
            int a = int.Parse(Userinput1);
            int b = int.Parse(Userinput2);
            int c = int.Parse(Userinput3);

            Max(a, b, c);
            Min(a, b, c);
            Sum(a, b, c);
            Average(a, b, c);
        }

        void Max(int a, int b, int c)
        {
            max = a;

            if (a >= max)
            {
                max = a;
            }
            if (b >= max)
            {
                max = b;
            }
            if (c >= max)
            {
                max = c;
            }
            Debug.Log($"ū��: {max}");
        }
        void Min(int a, int b, int c)
        {
            min = a;

            if (a <= min)
            {
                min = a;
            }
            if (b <= min)
            {
                min = b;
            }
            if (c <= min)
            {
                min = c;
            }
            Debug.Log($"������: {min}");
        }
        void Sum(int a, int b, int c)
        {
            sum = a + b + c;
            Debug.Log($"�հ�: {sum}");
        }

        void Average(int a, int b, int c)
        {
            average = (a + b + c) / 3;
            Debug.Log($"���: {average}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
