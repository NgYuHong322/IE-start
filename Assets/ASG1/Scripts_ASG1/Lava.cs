using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: Lava script
 */
public class Lava : MonoBehaviour
{
    
    public int DmgInt = 2;
    public int lavaDmg = 1;

    private float timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().DecreaseScore(lavaDmg);
            timer = 0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if (timer >= DmgInt)
            {
                other.gameObject.GetComponent<Player>().DecreaseScore(lavaDmg);
                timer = 0f;
            }
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