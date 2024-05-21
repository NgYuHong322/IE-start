using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: classwork script not for asg1
 */
public class Door : MonoBehaviour
{
    bool opened = false;

    private void OnTriggerEnter(Collider other)
    {
        //Check if gameObject enter & if it is player(tag)
        if(other.gameObject.tag == "Player" && !opened)
        {
            //Open Door
            OpenDoor();
        }
    }
     
    void OpenDoor()
    {
        //code for open door
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y += 90f;
        transform.eulerAngles = newRotation;
        opened = true;
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
