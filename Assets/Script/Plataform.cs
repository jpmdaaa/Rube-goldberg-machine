using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{

    private Transform tr;
    private Rigidbody rb;
    private bool active;
    private bool top;
    public bool horizontal;
    [SerializeField]
    private Button btn;
    public GameObject ball;

    [SerializeField]
    private float speed;

    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();

        top = true;
        ball.GetComponent<Rigidbody>().Sleep();
    }

    

    void Update()
    {
        if (active)
        {
            Movement();
        }
        else
        {
            rb.Sleep();

        }

        if(btn.active)
        {
            active = true;

        }

    }



    void Movement()
    {
        if(top)
        {
            rb.AddForce(new Vector3(0, speed, 0));
           

        }

        if(horizontal)
        {
            rb.AddForce(new Vector3(0,0, -3));
        }
     

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag=="Change")
        {
            rb.Sleep();
            top = false;
            horizontal = true;
        }
        if (other.gameObject.tag == "Change2")
        {
            Destroy(gameObject);
            ball.GetComponent<Rigidbody>().WakeUp(); 
        }

    }


}
