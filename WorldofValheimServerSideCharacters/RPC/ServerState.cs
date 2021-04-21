﻿using System.Collections.Generic;

namespace WorldofValheimServerSideCharacters
{

    public static class ServerState
    {

        public static ZPackage ClientLoadingData = null;

        public static bool ClientCanDC = false;


        public static byte[] default_character = global::WorldofValheimServerSideCharacters.Properties.Resources._default_character;

        public static List<ServerState.ConnectionData> Connections = new List<ServerState.ConnectionData>();

        public class ConnectionData
        {

            public ZRpc rpc;

            public float LastTimeSaved;
        }
    }
}
