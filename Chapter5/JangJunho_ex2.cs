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
            Debug.Log("50이상입니다.");
        else if (num < 50)
            Debug.Log("50미만입니다.");
    }
}
