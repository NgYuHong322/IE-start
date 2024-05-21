using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: .
 * Description: classwork script not for asg1
 */
public class ASG1_S1 : MonoBehaviour
{
    int myScore = 5;
    bool isCollected = false;
    string myName = "just a coin";
    float explorationTime = 5.5f;

    void OnCollisionEnter(Collision collision)
    {
        if(collision .gameObject.tag == "Player") 
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            Collected();
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("YES dont touch me!");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("NO STOP TOUCHING ME!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("NO TOUCH ME PLES!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("NO DONT GO!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("YES TOUCH ME");
    }

    void Spwan() 
    {
        
    }

    void Collected()
    {
        Debug.Log(gameObject.name + "GO AWAY U GOAT");
        Destroy(gameObject);
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
