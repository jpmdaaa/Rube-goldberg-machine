using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private Transform tr;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private string type;

    void Start()
    {
       tr= gameObject.GetComponent<Transform>();
    }

   
    void Update()
    {
        if(type=="1")
        tr.position = new Vector3(Player.transform.position.x, Player.transform.position.y, tr.position.z);
        if(type=="2")
         tr.position = new Vector3(tr.position.x, tr.position.y, Player.transform.position.z+10.0f);
        if(type=="3")
            tr.position = new Vector3(tr.position.x, Player.transform.position.y +6.0f, tr.position.z);
        if (type == "4")
            tr.position = new Vector3(Player.transform.position.x, Player.transform.position.y+6.0f , Player.transform.position.z+6.0f);
    }
}
