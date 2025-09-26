using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody bb;

    // Start is called before the first frame update
    void Start()
    {
        bb = GetComponent<Rigidbody>();

        bb.velocity = new Vector3(-30.0f, 0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
