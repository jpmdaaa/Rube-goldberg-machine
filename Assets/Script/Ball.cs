using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    private Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        slider = (Slider)FindObjectOfType(typeof(Slider));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        if(slider.active)
        {
            Destroy(gameObject);
        }
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Change")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dominos")
        {
            camera2.SetActive(false);
            camera3.SetActive(true);
            slider.active = true;

        }
        //collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
