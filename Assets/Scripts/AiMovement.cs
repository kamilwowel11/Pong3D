using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{
    Transform Ball;
    Transform Enemy;

    public Rigidbody rb;
    public float speed = 300f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;
        Enemy = GameObject.FindGameObjectWithTag("Enemy").transform;

        if (Ball.position.z > Enemy.position.z)
        {
            //Debug.Log("Ball Pos " + Ball.position.z);
            rb.AddForce(new Vector3(0f,0f,speed), ForceMode.Force);
        }
        else if (Ball.position.z < Enemy.position.z)
        {
           // Debug.Log("Ball Pos " + Ball.position.z);
            rb.AddForce(new Vector3(0f, 0f, -speed), ForceMode.Force);

        }

    }
}
