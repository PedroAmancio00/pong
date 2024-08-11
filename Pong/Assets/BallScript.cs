using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D playerRidgidBody;
    public float acceleration;
    public float xSpeed;
    float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        ySpeed = Random.Range(1, xSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        playerRidgidBody.velocity = new Vector2(xSpeed, ySpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        switch(collision.gameObject.tag)
        {
            case "Wall":
                xSpeed = xSpeed * acceleration;
                ySpeed = -ySpeed * acceleration;
                break;
            case "Player":
                xSpeed = -xSpeed * acceleration;
                ySpeed = ySpeed * acceleration;
                break;
            case "Finish":
                playerRidgidBody.transform.position = new Vector2(0, 0);
                ySpeed = Random.Range(1, 6);
                xSpeed = 6;
                break;
        }
    }
}
