using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 5; i++) 
        {
            string star = "";

            for (int j = 0; j <= 0 + i; j++)
                star += "??";

            for (int k = 0; k+i < 4 ; k++)
                star += "??";

            Debug.Log(star);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
