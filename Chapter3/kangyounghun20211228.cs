using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kangyounghun20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";
        int c = int.Parse(a) * int.Parse(b);


        Debug.Log($"�簢���� �ʺ�� {a}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {b}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {c}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}