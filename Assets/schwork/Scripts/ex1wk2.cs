using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1wk2 : MonoBehaviour
{
    int spawnRate = 10;
    bool isCollected = false;
    string coinName = "Legendary Coin";
    float deSpawnRate = 3.3f;
    int value = 100;
    void GetCollected()
    {
        Debug.Log("You obtained a coin!");
    }

    void Dropped()
    {
        Debug.Log("You dropped the coin.");
    }

    void Spawn()
    {
        Debug.Log("Coin spawned!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
