using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") {
            other.GetComponent<PlayerMovement>().enabled = false;
            GameManager.CompleteLevel(); }
            
    }
}
