using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{


    public GameObject cam8;
    public GameObject cam9;
  

    [SerializeField]
    GameObject end;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Change")
        {
            cam8.SetActive(false);
            cam9.SetActive(true);
            Debug.Log("CONDIÇAO TRIGGER = TRUE");
        }
        Debug.Log("ENTROU EM TRIGGER");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Change2")
        {
            end.SetActive(true);
            Destroy(gameObject);
            Debug.Log("CONDIÇAO COLLISION = TRUE");

        }


        Debug.Log("ENTROU EM COL");
    }

}
