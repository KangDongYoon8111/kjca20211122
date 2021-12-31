using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanDoWon_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "50";

        int number = int.Parse(userinput);
        if (number >= 70)
        {
            if(number>=90)
            {
                Debug.Log("A");
            }

            else if (number >= 80)
            {
                Debug.Log("B");
            }

            else
            {
                Debug.Log("C");
            }
        }
        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
