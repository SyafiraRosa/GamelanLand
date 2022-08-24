using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class RoomManager : MonoBehaviourPunCallbacks
{
    private string mapType;
    public TextMeshProUGUI OccupancyrateText_Sanggar;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;

        if (PhotonNetwork.IsConnectedAndReady)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region UI Callback Methods
    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public void OnEnterButtonClicked_Sanggar()
    {
        mapType = MultiplayerVRConstants.MAP_TYPE_SANGGAR;
        ExitGames.Client.Photon.Hashtable expectedCustomRoomProperties = new ExitGames.Client.Photon.Hashtable() { {MultiplayerVRConstants.MAP_TYPE_KEY, mapType } };
        PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties,0);
    }
    #endregion

    #region Photon Callback Methods
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log(message);
        CreateAndJoinRoom();
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("A room is create with the name : "+PhotonNetwork.CurrentRoom.Name);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("The Local player : "+ PhotonNetwork.NickName+ " Joined to "+PhotonNetwork.CurrentRoom.Name+" Player Count "+ PhotonNetwork.CurrentRoom.PlayerCount);

        if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey(MultiplayerVRConstants.MAP_TYPE_KEY))
        {
            object mapType;
            if (PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue(MultiplayerVRConstants.MAP_TYPE_KEY, out mapType))
            {
               Debug.Log("Joined room with role: "+(string)mapType);
                //Tambah room update loadlevel disini
                if ((string)mapType == MultiplayerVRConstants.MAP_TYPE_SANGGAR)
                {
                    //Load sanggar scene
                    PhotonNetwork.LoadLevel("SanggarPemainScene");
                }
            }
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName+" joined to. Player count : "+ PhotonNetwork.CurrentRoom.PlayerCount);
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        if (roomList.Count == 0)
        {
            //No room
            OccupancyrateText_Sanggar.text ="Player in Room " + 0 + "/" + 20;
        }

        foreach(RoomInfo room in roomList)
        {
            Debug.Log(room.Name);
            //Tambah room update occupancy disini
            if (room.Name.Contains(MultiplayerVRConstants.MAP_TYPE_SANGGAR))
            {
                //update room occupancy
                Debug.Log("Sanggar room. Player count is: " + room.PlayerCount);
                OccupancyrateText_Sanggar.text = "Player in Room " + room.PlayerCount + "/" + 20;
            }
        }
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined to Lobby");
    }
    #endregion

    #region Private Methods
    private void CreateAndJoinRoom()
    {
        string randomRoomName = "Room_" + mapType + Random.Range(0, 1000);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;


        string[] roomPropsInLobby = { MultiplayerVRConstants.MAP_TYPE_KEY };

        ExitGames.Client.Photon.Hashtable customRoomProperties = new ExitGames.Client.Photon.Hashtable() { {MultiplayerVRConstants.MAP_TYPE_KEY, mapType } };

        roomOptions.CustomRoomPropertiesForLobby = roomPropsInLobby;
        roomOptions.CustomRoomProperties = customRoomProperties;

        PhotonNetwork.CreateRoom(randomRoomName, roomOptions);
    }
    #endregion
}
