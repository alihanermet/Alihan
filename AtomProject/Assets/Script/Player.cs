using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
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
        if (isLocalPlayer)
        {
            transform.Translate(Input.GetAxis("Horizontal") * speed, 0, 0);
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(0, 100 * jspeed, 0);
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                CmdSpawn();
            }
        }
    }


    [Command]
    public void CmdSpawn()
    {
        GameObject sph = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
        NetworkServer.SpawnWithClientAuthority(sph, connectionToClient);
    }
}
