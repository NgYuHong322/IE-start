using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: coins
 */
public class Coin : MonoBehaviour
{
    //points to add
    int coinScore = 3;

    void Collected() 
    {
        Debug.Log("A Coin! Good Job!");
        Destroy(gameObject); // destroy gameobject when collected
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision .gameObject.tag == "Player")  // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(coinScore); // call the public fuction to add
            Collected();
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
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
