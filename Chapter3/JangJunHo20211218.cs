using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo20211218 : MonoBehaviour
{
    void Start()
    {
        string a = "30";
        string b = "40";

        Debug.Log($"�簢���� �ʺ�� {a}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {b}�Դϴ�.");

        int c = int.Parse(a) * int.Parse(b);
        Debug.Log($"�簢���� ���̴� {c}");
    }
}
