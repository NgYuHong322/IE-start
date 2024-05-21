using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: gold bar
 */
public class GoldBar : MonoBehaviour
{
    //points to add
    int goldBarScore = 10;

    void Collected()
    {
        Debug.Log("A Gold Bar! Good Job!");
        Destroy(gameObject); // destroy gameobject when collected
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(goldBarScore); // call the public fuction to add
            Collected();
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
