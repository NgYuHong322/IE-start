using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2wk2 : MonoBehaviour
{
    int a = 1;
    int x = 5;
    int y = 6;
    

    void QuickMath()
    {
        if (a < x)
        {
            int result = a + y;
            if (result < x)
            {
                Debug.Log("x is the biggest number");
            }
            else 
            {
                Debug.Log("x is not the biggest number");
            }
        }
        else 
        {
            int remainder = a % y;
            Debug.Log(remainder);
        }

    }

    void OnFire()
    {
        QuickMath();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //QuickMath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
