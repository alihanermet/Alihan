using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Manager : MonoBehaviour
{
    public NetworkManager manager;
    public GameObject NetManager;
    void Awake()
    {
        if (manager == null)
        {
            manager = NetManager.GetComponent<NetworkManager>();
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

}
