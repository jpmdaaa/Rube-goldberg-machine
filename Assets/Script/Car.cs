using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    private Transform tr;
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    public bool active;

    void Start()
    {

        tr = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            Movement();
        }
        else
            rb.Sleep();
    }

    void Movement()
    {
        rb.AddForce(new Vector3(speed, 0, 0));

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Dominos")
        {
          
            active = false;
        }
    }

}
