using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Text score;
    public ScoreCounter counter;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            collision.collider.gameObject.GetComponent<AudioSource>().enabled = true;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
