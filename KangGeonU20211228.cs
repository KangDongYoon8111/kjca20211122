using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangGeonU20211228 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        string a = "30";
        string b = "40";
        int c = int.Parse(a);
        int d = int.Parse(b);
        int e = c * d;

        Debug.Log($"�簢���� �ʺ�� {a}�Դϴ�");
        Debug.Log($"�簢���� ���̴� {b}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {e}�Դϴ�.");

    }


}
