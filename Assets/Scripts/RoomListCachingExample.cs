//using Photon.Realtime;
//using System.Collections.Generic;
//public class RoomListCachingExample : ILobbyCallbacks, IConnectionCallbacks
//{
//    private TypedLobby customLobby = new TypedLobby("customLobby",
//    LobbyType.Default);
//    private LoadBalancingClient loadBalancingClient;
//    private Dictionary<string, RoomInfo> cachedRoomList = new Dictionary<string,
//    RoomInfo>();
//    public void JoinLobby()
//    {
//        loadBalancingClient.JoinLobby(customLobby);
//    }
//    private void UpdateCachedRoomList(List<RoomInfo> roomList)
//    {
//        for (int i = 0; i < roomList.Count; i++)
//        {
//            RoomInfo info = roomList[i];
//            if (info.RemovedFromList)
//            {
//                cachedRoomList.Remove(info.Name);
//            }
//            else
//            {
//                cachedRoomList[info.Name] = info;
//            }
//        }
//    }

//    void ILobbyCallbacks.OnJoinedLobby()
//    {
//        cachedRoomList.Clear();
//    }
//    void ILobbyCallbacks.OnLeftLobby()
//    {
//        cachedRoomList.Clear();
//    }
//    void ILobbyCallbacks.OnRoomListUpdate(List<RoomInfo> roomList)
//    {
//        UpdateCachedRoomList(roomList);
//    }
//    void IConnectionCallbacks.OnDisconnected(DisconnectCause cause)
//    {
//        cachedRoomList.Clear();
//    }
//}
