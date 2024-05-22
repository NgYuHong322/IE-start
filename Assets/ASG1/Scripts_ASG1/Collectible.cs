using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Stores the current player that can interact with the object
    protected Player currentPlayer;

    // Method to increase player's movement speed
    protected void IncreaseMovementSpeed(float speedIncrease)
    {
        var playerController = currentPlayer.GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed += speedIncrease;
        }
    }

    // Method to increase player's jump height
    protected void IncreaseJumpHeight(float jumpHeightIncrease)
    {
        var playerController = currentPlayer.GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.JumpHeight += jumpHeightIncrease;
        }
    }
    void Collected()
    {
        Debug.Log("Collected Object!");
        Destroy(gameObject); // destroy gameobject when collected
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // check if the object that collided with it have player tag
        {
            Collected();
        }

    }
}
