using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX7 : MonoBehaviour
{
//    �� ���� ���� �Ѵް��� ��¥ ����
//�˷��ִ� ���α׷��� ������ּ���.

    // Start is called before the first frame update
    void Start()
    {
        int month = 1;
        int lastDay = DateTime.DaysInMonth(2022, month);

        Debug.Log($"{month}���� ������ ���� {lastDay} �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
