using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimYoungJoo20211228 : MonoBehaviour
{
    
    void Start()
    {
        string a = "30";
        string b = "40";

        print("�簢���� �ʺ�� " + a + "�Դϴ�.");
        print("�簢���� �ʺ�� " + b + "�Դϴ�.");

        int e = int.Parse(a);
        int f = int.Parse(b);

        int g = e * f;

        print("�簢���� ���̴�: "+g);

    }


}
