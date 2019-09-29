using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jspeed;
    public GameObject sphere;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, 0);
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 100 * jspeed, 0);
        }
    }


    //[Command]
    //public void CmdSpawn()
    //{
    //    GameObject sph = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
    //    NetworkServer.SpawnWithClientAuthority(sph, connectionToClient);
    //}
}
