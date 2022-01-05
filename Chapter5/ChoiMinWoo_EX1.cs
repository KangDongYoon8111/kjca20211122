using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX1 : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()        
    {
        string userInput = "110";

        int number = int.Parse(userInput);
        if (number >= 90)
        {
            Debug.Log("A");
        }
        else if (number >= 80)
        {
            Debug.Log("B");
        }
        else if (number >= 70)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("F");
        }
    
    

    }
    private void Update()
    {


    }
}
  
        


