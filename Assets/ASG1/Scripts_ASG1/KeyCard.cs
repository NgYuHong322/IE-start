using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: keycard
 */
public class KeyCard : MonoBehaviour
{
    int numOfKeyCard = 1;
    void OnCollected() 
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            collision.gameObject.GetComponent<Player>().IncreaseKeyCard(numOfKeyCard); // increase the keycard count in player script
            OnCollected();
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
