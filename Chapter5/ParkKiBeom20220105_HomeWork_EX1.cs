using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkKiBeom20220105_HomeWork_EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*int[] score = new int[5];
        score[0] = 60;
        score[1] = 80;
        score[2] = 30;
        score[3] = 100;
        score[4] = 20;*/
        int[] score = new int[] { 60, 80, 30, 100, 20 };
        int max = score[0];
        int min = score[0];

        for (int a = 0; a < score.Length; a++)
        {
            if (max < score[a])
            {
                max = score[a];
            }
            if (min > score[a])
            {
                min = score[a];
            }
        }
                Debug.Log("최대점수 : "+max+"점");
                Debug.Log("최소점수 : "+min+"점");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
