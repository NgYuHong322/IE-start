using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: hotdog
 */
public class HotDog : Collectible
{
    //points to add
    int hotDogScore = 1;
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(hotDogScore); // call the public fuction to add
            IncreaseMovementSpeed(20.0f); // Increase movement speed by 2
            IncreaseJumpHeight(10.0f); // Increase jump height by 1
            
        }

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
