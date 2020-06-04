using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public bool active;
    
    [SerializeField]
    private GameObject camera4;
    [SerializeField]
    private GameObject camera5;
    [SerializeField]
    private GameObject camera7;
    [SerializeField]
    private GameObject camera8;
    [SerializeField]
    private GameObject Ball;

    [SerializeField]
    private string typeCam;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active && typeCam=="1")
        {
            camera4.SetActive(false);
            camera5.SetActive(true);
            Destroy(gameObject);
        }


        if (active && typeCam == "2")
        {
            camera7.SetActive(false);
            camera8.SetActive(true);
            Destroy(gameObject);
            Ball.SetActive(true);

        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Dominos")
        {
            active = true;
        }
    }


}
