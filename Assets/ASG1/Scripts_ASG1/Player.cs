using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Author: NgYuHong
 * Date: 16/5/24
 * Description: Player script
 */

public class Player : MonoBehaviour
{
    // This will store text object 
    public TextMeshProUGUI scoreText;
    public GameObject textBox;

    public TextMeshProUGUI keyCardText;
    
    public GameObject kcTextBox;

    public GameObject startMenu;

    public GameObject endMenu;


    
    int currentScore = 0;
    public int keyCard = 0;
    int specialBox = 0;

    public void TextWarnKC() //no keycard warning 
    {
        kcTextBox.SetActive(true);  
    }

    public void EndMenuShow() // special ui popup when treature box is collected
    {
        if(specialBox == 1)
        {
            endMenu.SetActive(true); // when collectd set ui to show
            StartCoroutine(TimerCoroutine(5f)); // 5sec timer
            IEnumerator TimerCoroutine(float delay)
            {
                //wait for the 5sec
                yield return new WaitForSeconds(delay);
                endMenu.SetActive(false); // make ui dissapear from canvas
            }
            
        }
    }
    public void IncreaseSpecial(int addSpecial) // for the treature box so that ui will popup 
    {
        specialBox += addSpecial;
    }
    public void IncreaseScore(int scoreToAdd) 
    {
        currentScore += scoreToAdd;
        scoreText.text = currentScore.ToString(); // change curretnscore to a string
        Debug.Log(currentScore);
        textBox.SetActive(true); // make textbox ui visible on canvas
    }

    public void DecreaseScore(int scoreToRemove) //function to remove score
    {
        currentScore -= scoreToRemove;
        scoreText.text = currentScore.ToString();
        Debug.Log(currentScore);
    
    }

   

    public void IncreaseKeyCard(int keyCardToAdd) // add keycard 
    {
        keyCard += keyCardToAdd;
        keyCardText.text = keyCard.ToString();
        Debug.Log(keyCard);
    }
    // Start is called before the first frame update
    void Start()
    {
        kcTextBox.SetActive(false);
        endMenu.SetActive(false);

        StartCoroutine(TimerCoroutine(15f));

        IEnumerator TimerCoroutine(float delay)
        {
            // Wait for the specified amount of time
            yield return new WaitForSeconds(delay);

            startMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
           

    }
}
