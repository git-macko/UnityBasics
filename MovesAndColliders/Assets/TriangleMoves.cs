using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMoves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting: " + gameObject.name);
        
    }


    // Update is called once per frame
    public float speed = 10f;
    void Update()
    {
        Vector3 pos = transform.position;
        if(Input.GetKey(KeyCode.W)) {
            pos.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)) {
            pos.y -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)) {
            pos.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)) {
            pos.x += speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
