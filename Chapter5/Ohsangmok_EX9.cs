using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohsangmok_EX9 : MonoBehaviour
{
    int b;
    // Start is called before the first frame update
    void Start()
    
    {

        
        for (int a = 1; a < 11; a++)
        {
            if (a % 3 != 0)
            {
                Debug.Log(a);
               b += a;
            }
        }
        Debug.Log("1~10 �� 3���� ������ �������� �ʴ� ���� ��: " + b);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
