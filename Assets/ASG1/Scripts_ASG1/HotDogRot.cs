using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: rotten hotdog
 */
public class HotDogRot : MonoBehaviour
{
    // how much the hotdog minus
    int hotDogRotScore = -3;

    void Collected() // destroy gameobject when collected
    {
        Debug.Log("A Rotten HotDog! Oh NO!");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision) // when player collide with object
    {
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(hotDogRotScore); // call the public fuction to minus
            Collected(); //destroy object
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
