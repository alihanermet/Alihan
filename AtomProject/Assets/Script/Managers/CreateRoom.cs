using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateRoom : MonoBehaviour
{

    [SerializeField]
    private Text _roomName;
    private Text RoomName { get { return _roomName; } }

    public void ClickToCreateRoom()
    {
        if (PhotonNetwork.CreateRoom(RoomName.text))
        {
            print("create room succesfully sent.");
        }
        else
        {
            print("create room failed to sent.");
        }
    }

    private void OnPhotonCreateRoomFailed(object[] codeAndMsg)
    {
        print("create room failed: " + codeAndMsg[1]);
    }

    private void OnCreatedRoom()
    {
        print("Room created succesfully");
    }

}
