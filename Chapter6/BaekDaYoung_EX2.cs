using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaekDaYoung_EX2 : MonoBehaviour
{
    private void Start()
    {
        int a = 3;
        int b = 4;

        float c = 2.4f;
        float d = 3.1f;

        Debug.Log($"{a} + {b} = {Plus(a, b)}");
        Debug.Log($"{c} + {d} = {Plus(c, d)}");
    }

    public static float Plus(float userInpur1, float userInpur2)
    {
        return userInpur1 + userInpur2;
    }
}
