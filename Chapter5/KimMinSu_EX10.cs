using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSu_EX10 : MonoBehaviour
{



    
        void Start()
        {
            int a = 1;

            for (int i = 0; i < 5; i++)
            {
                string s = string.Empty;
                for (int j = 0; j < a; ++j)
                {
                    s += "¡Ú";
                }

                for (int j = 0; j < 5 - a; j++)
                {
                    s += "¡Ù";
                }

                Debug.Log(s);

                ++a;
            }
        }
    }



