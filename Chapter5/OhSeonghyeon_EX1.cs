using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "70";
        int number = int.Parse(userInput);
        if(number<=100)
        {
            if(number >= 90)
            { Debug.Log("A"); }
            else if (number >= 80)
            { Debug.Log("B"); }
            else if (number >= 70)
            { Debug.Log("C"); }
        }
        else if (number <= 69)
        { Debug.Log("F"); }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
