using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunHo_ex3 : MonoBehaviour
{
    public void Start()
    {
        string userInput = "356";
        int num = int.Parse(userInput);

        if (num % 3 == 0)
            Debug.Log("3�� ����Դϴ�");
        else
            Debug.Log("3�� ����� �ƴմϴ�.");
    }
}
