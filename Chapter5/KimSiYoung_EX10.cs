using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] score = new string[5];

        score[0] = "★☆☆☆☆";
        score[1] = "★★☆☆☆";
        score[2] = "★★★☆☆";
        score[3] = "★★★★☆";
        score[4] = "★★★★★";

        foreach (string a in score)
        {
            Debug.Log(a);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

//어려워욜...
