using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220104_EX9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int a = 1; a <= 10; a++)

        {
            if (a % 3 != 0)
            {
                Debug.Log(a);
                sum += a;
            }
            
            
        }
        Debug.Log("1~10�� 3���� ������ �������� �ʴ� ���� �� : " +sum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
