using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = .2f;
    public float maxZ = 12.0f;
    public KeyCode upKey;
    public KeyCode downKey;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            if (transform.position.z > maxZ)
            {
                transform.position = new Vector3(
                    transform.position.x, transform.position.y, maxZ);
            }
        }
        else if (Input.GetKey(downKey)) 
        {
            transform.position += new Vector3(0, 0, -(speed * Time.deltaTime));
            if (transform.position.z < -(maxZ))
            {
                transform.position = new Vector3(
                    transform.position.x, transform.position.y, -(maxZ));
            }
        }
    }
}
