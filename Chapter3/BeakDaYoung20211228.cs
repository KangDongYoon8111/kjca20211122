using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakDaYoung20211228 : MonoBehaviour
{
    
    void Start()
    {
        string a = "30";
        string b = "40";

        int c = int.Parse(a);
        int d = int.Parse(b);

        int e = c * d;


        Debug.Log("�簢���� �ʺ��"+a+"�Դϴ�.");
        Debug.Log("�簢���� ���̴�"+b+"�Դϴ�.");
        Debug.Log("�簢���� ���� :"+ e);

    }

    
    void Update()
    {
        
    }
}
