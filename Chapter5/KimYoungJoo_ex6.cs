using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_1 : MonoBehaviour
{
    public int a,b,c;  //ÀÔ·Â°ª(userInput)
    public char d;
    

    void Start()
    {
        
        switch (d)
        {

            case '+' :

                print(c=a + b);
                break;
            case '-':  
                print(c=a-b);
                break;
            case '*':
                print(c=a * b);
                break;
            case '/':
                print(c=a / b);
                break;
            case '%':
                print(c=a % b);
                break;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
