using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        Debug.Log("�簢���� �ʺ�� "+(a)+" �Դϴ�.");
        Debug.Log("�簢���� ���̴� "+(b)+" �Դϴ�.");
        
        int c = int.Parse(a);
        int d = int.Parse(b);
        Debug.Log("�簢���� ���̴� : " + (c * d));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
