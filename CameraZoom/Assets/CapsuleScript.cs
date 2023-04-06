using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb2d;
    private Vector3 lastVelocity;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = speed * new Vector2(1,1);
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb2d.velocity;

        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb2d.velocity = direction * Mathf.Max(speed, 0f);
    }
    
}
