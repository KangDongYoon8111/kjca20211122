using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JangJunho_ex2 : MonoBehaviour
{
    public void Start()
    {
        string userInput="66";
        int num = int.Parse(userInput);

        if (num >= 50)
            Debug.Log("50�̻��Դϴ�.");
        else if (num < 50)
            Debug.Log("50�̸��Դϴ�.");
    }
}
