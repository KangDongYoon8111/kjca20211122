using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KImGwiJong_Ex10 : MonoBehaviour
{
    string a = "";
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {        
        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k <= 0 + count; k++)
            {
                a = a + "¡Ú";
            }

            for (int j = 0; j < 4-count; j++)
            {
                a = a + "¡Ù";               
            }

            Debug.Log(a);
            count++;
            a = "";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
