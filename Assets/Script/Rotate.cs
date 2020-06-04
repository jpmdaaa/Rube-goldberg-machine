using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private Transform tr;
    private Rigidbody rb;
    [SerializeField]
    private float speed;

    void Start()
    {
        tr = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        transform.Rotate(new Vector3(speed,0,0));
    }
}
