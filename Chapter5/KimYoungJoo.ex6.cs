using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimYoungJoo___ex6 : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public char d;


    void Start()
    {

        switch (d)
        {

            case '+':

                print(c = a + b);
                break;
            case '-':
                print(c = a - b);
                break;
            case '*':
                print(c = a * b);
                break;
            case '/':
                print(c = a / b);
                break;
            case '%':
                print(c = a % b);
                break;

        }
    }
}
