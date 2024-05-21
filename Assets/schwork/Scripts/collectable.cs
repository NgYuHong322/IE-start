using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    bool isCollected = false;
    int myValue = 5;
    string myName = "just a coin";
    float explorationTime = 5.5f; //float need f

    void GetCollected()
    {
        Debug.Log("I got collected");      
    }

    // Start is called before the first frame update
    void Start()
    {
        GetCollected(); //calling function    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
