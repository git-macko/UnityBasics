using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoves : MonoBehaviour
{
    public float jumpSpeed = 25f;
    public float speed = 10f;
    private float direction = 0f;
    private Rigidbody2D player;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    

    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;

        if(Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
        

        //Jumping With the ball along mix with A and D movement
        //changes that was made: revamped the code to be simpler and added rigidbody, direction, jumpspeed
        //code of WSAD was mixed to this.
    }
}
