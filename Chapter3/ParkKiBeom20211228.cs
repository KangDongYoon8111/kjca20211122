using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int c = int.Parse(a);
        int d = int.Parse(b);

        Debug.Log("�簢���� �ʺ�� "+c+" �Դϴ�.");
        Debug.Log("�簢���� ���̴� "+d+" �Դϴ�.");
        Debug.Log("�簢���� ���̴� :" + c*d);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
