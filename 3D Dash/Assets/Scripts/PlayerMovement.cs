using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement parameters")]
    [Space]   
    public float vectorMoveSpeed;
    public float directionalMoveSpeed;
    [Space]
    [Header("Object references")]
    [Space]
    public Rigidbody rb;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        directionalMoveSpeed = 120f;
        vectorMoveSpeed = 8000f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, vectorMoveSpeed * Time.deltaTime);
        //rb.AddForce(Input.GetAxis("Horizontal") * directionalMoveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d")){
            rb.AddForce(directionalMoveSpeed * Time.deltaTime, 0,0,ForceMode.VelocityChange );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-directionalMoveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f)
        {
            audio.enabled = true;   
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
