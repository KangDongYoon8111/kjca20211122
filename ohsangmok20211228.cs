using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohsangmok20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";
        

        Debug.Log("�簢���� �ʺ�� " + a + "�Դϴ�.");
        Debug.Log("�簢���� ���̴� " + b + "�Դϴ�.");

        int f = int.Parse(a);
        int g = int.Parse(b);
        int h = f * g;

        Debug.Log("�簢���� ���̴� : " + h);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
