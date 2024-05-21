using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: treature box
 */
public class TreatureBox : MonoBehaviour
{
    //points to add
    int treatureBoxScore = 100;
    int specialBox = 1;

    void Collected()
    {
        Debug.Log("BIIIIG! Secret Item Found!");
        Destroy(gameObject); // destroy gameobject when collected
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(treatureBoxScore); // call the public fuction to add
            collision.gameObject.GetComponent<Player>().IncreaseSpecial(specialBox); // // call the public fuction to add to special box
            Collected();
            collision.gameObject.GetComponent<Player>().EndMenuShow(); //run the public function in player script.
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
