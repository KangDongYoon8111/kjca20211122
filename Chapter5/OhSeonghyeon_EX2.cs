using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "49";
        int number = int.Parse(userInput);
        if (number >= 0)
        {
            if (number >= 50)
            { Debug.Log("50 이상의 수"); }
            else if (number < 50)
            { Debug.Log("50미만의 수"); }
            
        }







    }
}

  
