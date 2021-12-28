using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo20211218 : MonoBehaviour
{
    void Start()
    {
        string a = "30";
        string b = "40";

        Debug.Log($"사각형의 너비는 {a}입니다.");
        Debug.Log($"사각형의 높이는 {b}입니다.");

        int c = int.Parse(a) * int.Parse(b);
        Debug.Log($"사각형의 넓이는 {c}");
    }
}
