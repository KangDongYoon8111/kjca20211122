using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeJiHye20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string a = "30";
        string b = "40";




        Debug.Log("�簢���� ���̴� " + (a) + " �Դϴ�.");
        Debug.Log("�簢���� ���̴� " + (b) + " �Դϴ�.");

        int d = int.Parse(a);
        int e = int.Parse(b);

        int c = (d * e);

        Debug.Log("�簢���� ���̴�" +(c)+"�Դϴ�.");

    }
}
