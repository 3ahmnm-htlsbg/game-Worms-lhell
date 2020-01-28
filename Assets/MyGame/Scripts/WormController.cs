using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    
    void Start()
    {
       /*if (x>0) {
        
            Debug.Log("x ist größer als 0");
        
        }

        else

        {
            Debug.Log("x ist kleiner als 0");

        }

       if (text == "oidaaaaaaaa") {
           Debug.Log("do steht oidaaaaaaaa");
        }
        else
    {
            Debug.Log("Wos isn mid dia");
     } */
        
        if (x>10) {
        
            Debug.Log("x ist größer als 10");
        
        }
        
        else
        
        {
            Debug.Log("x ist kleiner gleich 10");
        }
        
    }
}
