using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{

    private Transform tr;
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    public bool active;
    [SerializeField]
    private GameObject camera3;
    [SerializeField]
    private GameObject camera4;
    private Car car;

    // Start is called before the first frame update
    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
        car = (Car)FindObjectOfType(typeof(Car));
    }

    // Update is called once per frame
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
          

      
    }



    void Movement()
    {
        rb.AddForce(new Vector3(0, 0, speed));

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Change")
        {
            active = false;
            camera3.SetActive(false);
            camera4.SetActive(true);
            car.active = true;
        }
    }

}


