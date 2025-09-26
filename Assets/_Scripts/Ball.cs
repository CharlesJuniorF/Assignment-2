using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip bounceSound;
    private float speed = 40.0f;
    private Rigidbody bb;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        bb = GetComponent<Rigidbody>();


        //create a random angle
        float angle = Random.value * 60 - 30; //-30 to 30

        //decide if it's going right or left
        if (Random.value < .5f)
        {
            angle += 180;
        }

        //set the ball to that angle
        transform.eulerAngles += new Vector3(0, angle, 0);

        //give it forward speed
        bb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("Floor"))
        {
            AudioSource.PlayClipAtPoint(bounceSound, transform.position);
        }
    }
}
