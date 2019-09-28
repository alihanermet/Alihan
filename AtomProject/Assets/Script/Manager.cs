using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Manager : MonoBehaviour
{
    public float speed;

    public NetworkManager manager;

    public GameObject NetManager;
    public GameObject Player;

    public Rigidbody rb;

    void Awake()
    {
        if (manager == null)
        {
            manager = NetManager.GetComponent<NetworkManager>();
        }
    }

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
        if (!manager.IsClientConnected() && !NetworkServer.active)
        {
            manager.StartHost();
        }
        
    }

    public void JoinButton()
    {
        if (!manager.IsClientConnected() && !NetworkServer.active)
        {
            manager.StartClient();
        }

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
