using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGeonU20211231_EX10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "";
        int count = 4;
        //ĥ�̵� �� ���
        for(int k = 0; k<=4; k++)
        {
            for (int i = 1; i <= 5 - count; i++)
            {
                a = a + "��";
            }
            //ĥ�� �ȵ� �� ���
            for (int j = -1 + count; j >= 0; j--)
            {
                a = a + "��";
            }
            count--;
            Debug.Log(a);
            a = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
