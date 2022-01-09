using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class ParkKiBeom20220104_EX10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            string star = "";

            for(int j = 0; j <= i; j++)
            {
                star += "★";
            }

            for(int k = 0 + i; k < 4; k++)
            {
                star += "☆";
            }

            Debug.Log(star);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
