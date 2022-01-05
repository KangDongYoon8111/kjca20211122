using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiMinWoo_EX2 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num>=50)
        {
            Debug.Log("50이상입니다.");
        }
        else
        {
            Debug.Log("50미만입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
