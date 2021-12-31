using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "49";

        int number = int.Parse(userinput);

        if (number >= 50)
        {
            Debug.Log("50이상");
        }

        else
        {
            Debug.Log("50미만");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
