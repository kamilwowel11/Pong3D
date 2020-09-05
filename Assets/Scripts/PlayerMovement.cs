using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public CharacterController controller;
    public Rigidbody rb;

    public float speed = 1000f;

    private Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        //float vertical = Input.GetAxisRaw("Vertical");
        //Vector3 direction = new Vector3(0f, 0f, vertical).normalized;
        //if (direction.magnitude >= 0f)
        //{

        //    controller.Move(direction * Time.deltaTime * speed);
        //}
        inputVector = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
        rb.velocity = inputVector;

    }
}
