using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector3 initialImpact;
    public Rigidbody rb;
    public ScoreUI UI;
    public ParticleSystem boomRed;
    public ParticleSystem boomBlue;
    Ball ball;


    // Start is called before the first frame update
    void Start()
    { 
        ball = gameObject.GetComponent<Ball>();
        rb.AddForce(initialImpact, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "BackPlayerWall")
        {
            UI.scorePlayer++;
            ball.transform.position = new Vector3(0f, 3.1f, 0f);
            rb.velocity = Vector3.zero;
            boomBlue.Play();

            rb.AddForce(new Vector3(UnityEngine.Random.Range(-10,-11),0f, UnityEngine.Random.Range(-10,-5)), ForceMode.Impulse);

        }
        else if(other.tag == "BackEnemyWall")
        {
            UI.scoreEnemy++;
            boomRed.Play();
            ball.transform.position = new Vector3(0f, 3.1f, 0f);
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(UnityEngine.Random.Range(10, 11), 0f, UnityEngine.Random.Range(10, 5)), ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
