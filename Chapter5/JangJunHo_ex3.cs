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
            Debug.Log("3의 배수입니다");
        else
            Debug.Log("3의 배수가 아닙니다.");
    }
}
