using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: Mimic coins
 */
public class MimicCoin : MonoBehaviour
{
    // points to deduct
    int mimicCoinScore = -5;

    void Collected() 
    {
        Debug.Log("A Coin...... NO, it is a fake!");
        Destroy(gameObject); // destroy gameobject when collected
    }

    private void OnCollisionEnter(Collision collision) // when player collide with object
    {
        if (collision .gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(mimicCoinScore); // call the public fuction to minus
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
