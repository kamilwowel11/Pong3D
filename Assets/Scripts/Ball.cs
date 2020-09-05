using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector3 initialImpact;
    public Rigidbody rb;
    public ScoreUI UI;
    public ParticleSystem boomRedParticles;
    public ParticleSystem boomBlueParticles;
    public GameObject Wall1;
    public GameObject Wall2;
    private bool color = true;
    Ball ball;


    // Start is called before the first frame update
    void Start()
    { 
        ball = gameObject.GetComponent<Ball>();
        rb.AddForce(initialImpact, ForceMode.Impulse);
        
        //Instantiate(boomRedParticles.gameObject);
       // Instantiate(boomBlueParticles.gameObject);

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "BackPlayerWall")
        {
            UI.scorePlayer++;

            //GameObject vfx;
            //vfx = Instantiate(boomBlue);
            //vfx.transform.position = ball.transform.position;
            //Destroy(vfx, 2f);
            GameObject vfx;
            vfx = Instantiate(boomRedParticles.gameObject);
            vfx.transform.position = ball.transform.position;

            Destroy(vfx, 2f);


            ball.transform.position = new Vector3(0f, 3.1f, 0f);
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(UnityEngine.Random.Range(-10,-11),0f, UnityEngine.Random.Range(-10,-5)), ForceMode.Impulse);

        }
        else if(other.tag == "BackEnemyWall")
        {
            UI.scoreEnemy++;

            //GameObject vfx;
            //vfx = Instantiate(boomBlue);
            //vfx.transform.position = ball.transform.position;
            //Destroy(vfx, 2f);
            GameObject vfx;
            vfx  = Instantiate(boomBlueParticles.gameObject);
            vfx.transform.position = ball.transform.position;

            Destroy(vfx, 2f);



            ball.transform.position = new Vector3(0f, 3.1f, 0f);
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(UnityEngine.Random.Range(10, 11), 0f, UnityEngine.Random.Range(10, 5)), ForceMode.Impulse);
        }
        else if (other.tag == "GameBorder")
        {
            var wall1Renderer = Wall1.GetComponent<Renderer>();
            var wall2Renderer = Wall2.GetComponent<Renderer>();
            if (color == true)
            {
                wall1Renderer.material.SetColor("_Color", Color.red);
                wall2Renderer.material.SetColor("_Color", Color.red);
                color = false;
            }
            else
            {
                wall1Renderer.material.SetColor("_Color", Color.blue);
                wall2Renderer.material.SetColor("_Color", Color.blue);
                color = true;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
