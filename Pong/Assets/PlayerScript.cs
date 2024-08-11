using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRidgidBody;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRidgidBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        playerRidgidBody.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            playerRidgidBody.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerRidgidBody.velocity = new Vector2(0, -speed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            playerRidgidBody.velocity = new Vector2(0, 0);
        }
    }
}
