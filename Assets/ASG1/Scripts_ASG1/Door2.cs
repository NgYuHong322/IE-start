using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: sliding door that need keycard to unlock
 */
public class Door2 : MonoBehaviour
{

    bool opened = false;
    public float slideDistance = 4f; // Distance to slide the door to the right
    public float slideDuration = 2f; // Time over which the door slides

    private void OnTriggerEnter(Collider other)
    {
        // Check if gameObject enters & if it is player(tag)
        if (other.gameObject.tag == "Player" && !opened)
        {
            // check if player have card
            if (other.gameObject.GetComponent<Player>().keyCard >= 1)
            {
                // Open Door
                StartCoroutine(SlideDoor(Vector3.right * slideDistance)); 
            }
            else
            {
                other.gameObject.GetComponent<Player>().TextWarnKC();
                
                StartCoroutine(TimerCoroutine(5f));

                IEnumerator TimerCoroutine(float delay)
                {
                 // Wait for the specified amount of time
                    yield return new WaitForSeconds(delay);

                    // Execute your code after the delay
                    other.gameObject.GetComponent<Player>().kcTextBox.SetActive(false);
                }
            }
            
        }
    }

    IEnumerator SlideDoor(Vector3 direction) // to slide the door
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + direction;
        float elapsedTime = 0f;

        while (elapsedTime < slideDuration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / slideDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = endPosition;
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
