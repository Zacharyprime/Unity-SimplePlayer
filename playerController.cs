using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    //Movement Vars
    Rigidbody rb;
    public float l_Speed, m_Speed;
    private float x;
    private Vector3 rotateValue;


    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        rb = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Mouse X");
        rotateValue = new Vector3(0, x * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;


        m_Speed = 5.0f;
        if (Input.GetKey("left shift"))
        {
            //RUN!
            m_Speed = m_Speed * 2;
        }


        if (Input.GetKey("w"))
        {
            //Move Forward
            transform.Translate(transform.forward * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey("s"))
        {
            //Move Backward
            transform.Translate(-transform.forward * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey("a"))
        {
            //Move to the Left
            transform.Translate(-transform.right * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey("d"))
        {
            //Move to the right
            transform.Translate(transform.right * Time.deltaTime * m_Speed, Space.World);
        }


        if (Input.GetKey("space"))
        {
            //Jump
            Debug.Log("Vert. Velocity: " + rb.velocity.y);
            if (rb.velocity.y == 0)
            {
                rb.AddForce(Vector3.up * 1.5f, ForceMode.VelocityChange);
            }
        }

    }

}
