using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal")* 50;
        float v = Input.GetAxis("Vertical")  * 50;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5000000);
        }
        

        Vector3 vel = rb.velocity;
        vel.x = h;
        vel.z = v;
        rb.velocity = vel;

        
    }
}
