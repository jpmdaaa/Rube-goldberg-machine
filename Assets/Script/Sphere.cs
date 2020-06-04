using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Plataform pl;
    private Rigidbody rb;

    [SerializeField]
    private GameObject Camera5;
    [SerializeField]
    private GameObject Camera6;
    [SerializeField]
    private GameObject Camera7;



    void Start()
    {
        pl = (Plataform)FindObjectOfType(typeof(Plataform));
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pl.horizontal)
        {
            rb.AddForce(new Vector3(0, 0, -3));
            Camera5.SetActive(false);
            Camera6.SetActive(true);
         
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Dominos")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1));
            Camera6.SetActive(false);
            Camera7.SetActive(true);    
            Destroy(gameObject);
            
        }
    }

}
