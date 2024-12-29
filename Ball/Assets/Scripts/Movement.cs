using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float inputHor;
    float inputVer;
    float speed;
    bool isGronded;
    [SerializeField] float normalSpeed = 30;
    [SerializeField] float maxSpeed = 80;
    [SerializeField] float jumpForce = 10;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = maxSpeed;
        }
        else
        {
            speed = normalSpeed;
        }
        if (Input.GetKey(KeyCode.Space)&&isGronded==true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        inputHor = Input.GetAxis("Horizontal") * speed;
        rb.AddForce(Vector3.right * inputHor, ForceMode.Impulse);
        inputVer = Input.GetAxis("Vertical") * speed;
        rb.AddForce(Vector3.forward * inputVer, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGronded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGronded = false;
        }
    }
}
