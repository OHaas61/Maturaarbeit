using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

     
    }

    public void Move(float xInput, float zInput)
    {
        rb.velocity = new Vector3(xInput, rb.velocity.y, zInput);

    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * 500);
    }
}
