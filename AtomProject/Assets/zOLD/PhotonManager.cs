using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class PhotonManager : Photon.MonoBehaviour
{
    [SerializeField]private GameObject Cubembe;



    public void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.0");
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom(
            "Room", 
            new RoomOptions() { MaxPlayers = 2 }, 
            TypedLobby.Default
            );
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Cubembe", Cubembe.transform.position, Quaternion.identity, 0);
    }

}
