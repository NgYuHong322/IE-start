using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA1 : MonoBehaviour
{
    int numOne = 1;
    int numTwo = 2;


    void IntCompare()
    {
        if (numOne == numTwo)
        {
            Debug.Log("The numbers are equal!");
        }
        else 
        {
            //check numOne > numTwo, if T, bigNum = numOne. If F, bigNum = numTwo
            int bigNum = (numOne > numTwo) ? numOne : numTwo; 
            Debug.Log("The number " + bigNum + " is the largest!");
        }
    }

    void PrintLoop()
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(i + "");
        }
    }

    void WhileLoop()
    {
        int a = 0;
        while (a < 10)
        {
            Debug.Log("Hello World");
            a++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            IntCompare();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            PrintLoop();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            WhileLoop();
        }

    }
}
