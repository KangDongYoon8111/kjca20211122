using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhSeonghyeon_EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "50";
        int number = int.Parse(userInput);
        if (number >= 0)
        {
            if ((number %= 3) == 0)
            {
                Debug.Log("3의 배수");
            }
            else if ((number %= 3) >= 1)
            {
                Debug.Log("3의 배수가 아닌수");
            }

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
