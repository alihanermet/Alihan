using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float speed;


    public GameObject NetManager;
    public GameObject Player;

    public Rigidbody rb;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            rb = Player.GetComponent<Rigidbody>();
        }
    }

    public void HostButton()
    {

    }

    public void JoinButton()
    {

    }


    public void AssignPlayer()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = Player.GetComponent<Rigidbody>();
    }


    public void left()
    {
        rb.velocity = new Vector3(-1 * speed, 0, 0);
    }
    public void right()
    {
        rb.velocity = new Vector3(1 * speed, 0, 0);
    }
    public void up()
    {
        rb.velocity = new Vector3(0, 1 * speed, 0);
    }

}
