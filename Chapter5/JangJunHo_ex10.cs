using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex10 : MonoBehaviour
{
    void Start()
    {
        /*string[] a = { "�ڡ١١١�", "�ڡڡ١١�", "�ڡڡڡ١�", "�ڡڡڡڡ�", "�ڡڡڡڡ�" };
        for (int i = 0; i < 5; i++)
            Debug.Log(a[i]); �ƹ�ư ���� ������ ������ ���*/


        string a = "��";
        string b = "��";
        string c = "";
        string d = "";
        for (int i = 0; i < 5; i++)
        {
            d += a;
            c += d;
            for (int k = 4; k > i; k--)
                c += b;

            Debug.Log(c);
            c = "";
        }
    }

}
