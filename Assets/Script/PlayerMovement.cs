using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float Speed = 2000f;
    public float LR = 1000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(LR * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-LR * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        
    }
}
